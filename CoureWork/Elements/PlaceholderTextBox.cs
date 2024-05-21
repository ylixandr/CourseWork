using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoureWork.Elements
{
	public class PlaceholderTextBox : TextBox
	{
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			if (!string.IsNullOrWhiteSpace(_placeholderText))
			{
				SendMessage(Handle, EM_SETCUEBANNER, 0, _placeholderText);
			}
		}

		string _placeholderText = "";
		public string PlaceholderText
		{
			get { return _placeholderText; }
			set
			{
				_placeholderText = value ?? "";
				if (IsHandleCreated && !string.IsNullOrWhiteSpace(_placeholderText))
				{
					SendMessage(Handle, EM_SETCUEBANNER, 0, _placeholderText);
				}
			}
		}

		const int EM_SETCUEBANNER = 0x1501;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern Int32 SendMessage(
			IntPtr hWnd,
			int msg,
			int wParam,
			[MarshalAs(UnmanagedType.LPWStr)] string lParam);
	}
}
