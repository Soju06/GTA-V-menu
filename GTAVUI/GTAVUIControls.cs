using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GTAVUI
{
    public class VListViewItem
    {
        public string Text;
        public bool FolderMode = false;
        public bool Enabled = true;
        public bool LabelMode = false;
        public bool Select = false;
        public bool DescriptionUsed = false;
        public string DescriptionText;
        public int DescriptionHSize = 1;
        public object Tag;
        public Guid Guid { get; private set; }
        public VListViewItem() { Guid = Guid.NewGuid(); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="enabled"></param>
        /// <param name="folderMode"></param>
        /// <param name="labelMode"></param>
        /// <param name="select"></param>
        /// <param name="descriptionUsed"></param>
        /// <param name="descriptionText"></param>
        /// <param name="descriptionHSize"></param>
        /// <param name="tag"></param>
        public VListViewItem(string text, bool enabled = true, bool folderMode = false, bool labelMode = false, bool select = false, bool descriptionUsed = false, string descriptionText = "", int descriptionHSize = 1, object tag = null)
        {
            Guid = Guid.NewGuid();
            Text = text;
            Select = select;
            Enabled = enabled;
            FolderMode = folderMode;
            LabelMode = labelMode;
            DescriptionUsed = descriptionUsed;
            DescriptionText = descriptionText;
            DescriptionHSize = descriptionHSize;
            Tag = tag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="guid"></param>
        /// <param name="enabled"></param>
        /// <param name="folderMode"></param>
        /// <param name="labelMode"></param>
        /// <param name="select"></param>
        /// <param name="descriptionUsed"></param>
        /// <param name="descriptionText"></param>
        /// <param name="descriptionHSize"></param>
        /// <param name="tag"></param>
        public VListViewItem(string text, Guid guid, bool enabled = true, bool folderMode = false, bool labelMode = false, bool select = false, bool descriptionUsed = false, string descriptionText = "", int descriptionHSize = 1, object tag = null)
        {
            Guid = guid;
            Text = text;
            Select = select;
            Enabled = enabled;
            FolderMode = folderMode;
            LabelMode = labelMode;
            DescriptionUsed = descriptionUsed;
            DescriptionText = descriptionText;
            DescriptionHSize = descriptionHSize;
            Tag = tag;
        }
    }

    public class Utils
    {
        public class Fonts
        {
            public static FontFamily FontFamilyFromByte(byte[] byteArray)
            {
                PrivateFontCollection pfCollection = new PrivateFontCollection();
                IntPtr pFont = Marshal.AllocHGlobal(byteArray.Length);
                if (pFont == IntPtr.Zero)
                    return null;
                Marshal.Copy(byteArray, 0, pFont, byteArray.Length);
                pfCollection.AddMemoryFont(pFont, byteArray.Length);
                Marshal.FreeHGlobal(pFont);
                if (pfCollection.Families.Length == 0)
                    return null;
                return pfCollection.Families[0];
            }
        }
    }
}