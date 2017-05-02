using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp00
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         CefSettings settings = new CefSettings();
         Cef.Initialize(settings);

         String pageAddress = $@"{Application.StartupPath}\HtmlResources\html\index.html";
         ChromiumWebBrowser browser = new ChromiumWebBrowser(pageAddress);
         Controls.Add(browser);
         browser.Dock = DockStyle.Fill;

         BrowserSettings browserSettings = new BrowserSettings
         {
            FileAccessFromFileUrls = CefState.Enabled,
            UniversalAccessFromFileUrls = CefState.Enabled
         };
         browser.BrowserSettings = browserSettings;
         browser.RegisterJsObject("cefCustomObject", new CefCustomObject(browser, this));
      }

      private void Form1_FormClosing(object sender, EventArgs e)
      {
         Cef.Shutdown();
      }

   }
}
