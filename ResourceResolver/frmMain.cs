using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Drawing.Imaging;

namespace ResourceResolver
{
	public partial class frmMain : Form
	{
		#region Types
		public class ItemSorter : IComparer<IResourceItem>
		{
			public int Compare(IResourceItem x, IResourceItem y)
			{
				if (x == null || y == null || x.ResourceType != y.ResourceType)
					return 0;
				switch (x.ResourceType)
				{
					case ResourceType.String:
						StringResourceItem itemx = x as StringResourceItem;
						StringResourceItem itemy = y as StringResourceItem;
						return itemy.Text.CompareTo(itemx.Text);
					case ResourceType.Image:
						ImageResourceItem imagex = x as ImageResourceItem;
						ImageResourceItem imagey = y as ImageResourceItem;
						return imagey.Length.CompareTo(imagex.Length);
					case ResourceType.Icon:
						IconResourceItem iconx = x as IconResourceItem;
						IconResourceItem icony = y as IconResourceItem;
						return icony.Length.CompareTo(iconx.Length);
					default:
						break;
				}
				return 0;
			}
		}
		#endregion

		#region Members
		#endregion

		#region Properties
		public ResourceContainer SelectedResourceContainer
		{
			get { return cbResources.SelectedItem as ResourceContainer; }
		}

		public ResourceTypeContainer SelectedResourceTypeContainer
		{
			get { return cbResourceTypes.SelectedItem as ResourceTypeContainer; }
		}

		public IResourceItem SelectedItem
		{
			get { return lbItems.SelectedItem as IResourceItem; }
		}
		#endregion

		#region Initialization
		public frmMain()
		{
			InitializeComponent();
		}
		#endregion

		#region Methods
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			cbResourceTypes.Items.Add(new ResourceTypeContainer(ResourceType.String));
			cbResourceTypes.Items.Add(new ResourceTypeContainer(ResourceType.Image));
			cbResourceTypes.Items.Add(new ResourceTypeContainer(ResourceType.Icon));
		}

		private void miOpen_Click(object sender, EventArgs e)
		{
			_SelectResourceFile();
		}

		private void _SelectResourceFile()
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultFilePath))
				{
					dialog.InitialDirectory = Properties.Settings.Default.DefaultFilePath;
				}
				dialog.Filter = "Assembly Files|*.dll;*.exe";
				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					Properties.Settings.Default.DefaultFilePath = Path.GetDirectoryName(dialog.FileName);
					Properties.Settings.Default.Save();
					txtFileName.Text = dialog.FileName;
					cbResources.Items.Clear();
					cbResources.SelectedIndex = -1;
					cbResources.Text = string.Empty;
				}
			}
		}

		private void miLoadResource_Click(object sender, EventArgs e)
		{
			_LoadResources();
		}

		private void _LoadResources()
		{
			lblMessage.Text = "Resources are loading...";
			lblMessage.Visible = true;
			Application.DoEvents();

			string fileName = txtFileName.Text;
			if (string.IsNullOrEmpty(fileName))
			{
				lblMessage.Visible = false;
				return;
			}
			cbResources.Items.Clear();
			Assembly assembly = Assembly.LoadFile(fileName);
			string[] names = assembly.GetManifestResourceNames();
			Array.Sort(names);
			for (int i = 0; i < names.Length; i++)
			{
				ManifestResourceInfo info = assembly.GetManifestResourceInfo(names[i]);
				ResourceContainer container = new ResourceContainer(names[i]);
				container.Resolve(assembly, names[i]);
				cbResources.Items.Add(container);
			}
			if (cbResources.Items.Count > 0)
				cbResources.SelectedIndex = 0;
			lblMessage.Visible = false;
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			_SelectResourceFile();
		}

		private void btnLoadResources_Click(object sender, EventArgs e)
		{
			_LoadResources();
		}

		private void cbResources_SelectedIndexChanged(object sender, EventArgs e)
		{
			_LoadResourceItems();
		}

		private void cbResourceTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			_LoadResourceItems();
		}

		private void _LoadResourceItems()
		{
			lblMessage.Text = "Loading...";
			lblMessage.Visible = true;
			Application.DoEvents();
			lbItems.Items.Clear();
			lbItems.ItemHeight = 1;
			if (SelectedResourceContainer != null && SelectedResourceTypeContainer != null)
			{
				List<IResourceItem> items = SelectedResourceContainer.Filter(SelectedResourceTypeContainer.ResourceType);
				items.Sort(new ItemSorter());
				for (int i = 0; i < items.Count; i++)
				{
					lbItems.Items.Add(items[i]);
				}
				if (lbItems.Items.Count > 0)
					lbItems.SelectedIndex = 0;
			}
			lblMessage.Visible = false;
		}

		private void lbItems_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index != -1)
			{
				e.DrawBackground();
				IResourceItem item = lbItems.Items[e.Index] as IResourceItem;
				item.Draw(e.Graphics, lbItems.Font, e.Bounds);
				if (item.BoundHeight > (lbItems.ItemHeight - 2))
				{
					lbItems.ItemHeight = ((item.BoundHeight + 2) > 128) ? 128 : item.BoundHeight + 2;
				}
			}
		}

		private void lbItems_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			IResourceItem item = lbItems.Items[e.Index] as IResourceItem;
			e.ItemHeight = item.BoundHeight;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (SelectedItem != null)
			{
				SelectedItem.Save();
			}
		}

		private void contextMenuSave_Opening(object sender, CancelEventArgs e)
		{
			if (SelectedItem == null)
			{
				contextMenuSave.Items[0].Enabled = false;
			}
			else
			{
				contextMenuSave.Items[0].Enabled = true;
			}
		}

		private void btnSaveAll_Click(object sender, EventArgs e)
		{
			_SaveAllImages();
		}

		private void saveAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_SaveAllImages();
		}

		private void _SaveAllImages()
		{
			if (cbResources.Items.Count == 0)
			{
				_LoadResources();
			}
			lblMessage.Text = "Saving...";
			Application.DoEvents();
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultSavePath))
				{
					dialog.SelectedPath = Properties.Settings.Default.DefaultSavePath;
				}
				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					Properties.Settings.Default.DefaultSavePath = dialog.SelectedPath;
					Properties.Settings.Default.Save();
					string iconDirectory = dialog.SelectedPath + "\\Icons";
					string imageDirectory = dialog.SelectedPath + "\\Images";
					if (!Directory.Exists(iconDirectory))
						Directory.CreateDirectory(iconDirectory);
					if (!Directory.Exists(imageDirectory))
						Directory.CreateDirectory(imageDirectory);
					for (int resourceIndex = 0; resourceIndex < cbResources.Items.Count; resourceIndex++)
					{
						ResourceContainer container = cbResources.Items[resourceIndex] as ResourceContainer;
						string[] names = container.Name.Split(new char[] { '.' });

						for (int itemIndex = 0; itemIndex < container.Items.Count; itemIndex++)
						{
							IResourceItem item = container.Items[itemIndex];
							string fileName = string.Empty;
							if (item.ResourceType == ResourceType.Icon)
							{
								IconResourceItem resourceItem = item as IconResourceItem;
								if (resourceItem.Icon != null)
								{
									if (names.Length > 1)
									{
										fileName = dialog.SelectedPath + "\\Icons\\" + names[names.Length - 2] + ".ico";
										using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
										{
											resourceItem.Icon.Save(fs);
											fs.Flush();
										}
									}
								}
							}
							else if (item.ResourceType == ResourceType.Image)
							{
								ImageResourceItem imageItem = item as ImageResourceItem;
								if (imageItem.Image != null)
								{
									string name = imageItem.Name;
									if (imageItem.Index != -1)
									{
										name = imageItem.Index.ToString();
									}
									fileName = dialog.SelectedPath + "\\Images\\" + names[names.Length - 2] + "_" + imageItem.Width.ToString() + "_" + name + ".png";
									imageItem.Image.Save(fileName, ImageFormat.Png);
								}
							}
						}
					}
					MessageBox.Show("Operation Finished", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			lblMessage.Visible = false;
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (frmAbout dialog = new frmAbout())
			{
				dialog.ShowDialog();
			}
		}
		#endregion
	}
}
