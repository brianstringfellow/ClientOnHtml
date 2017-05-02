namespace CefSharp00
{
   using CefSharp;
   using CefSharp.WinForms;
   using System.Diagnostics;

   public class CefCustomObject
   {
      private static ChromiumWebBrowser _instanceBrowser;
      private static Form1 _instanceForm;

      public CefCustomObject(ChromiumWebBrowser originalBrowser, Form1 mainForm)
      {
         _instanceBrowser = originalBrowser;
         _instanceForm = mainForm;
      }

      public void ShowDevTools()
      {
         _instanceBrowser.ShowDevTools();
      }

      public void OpenCmd()
      {
         ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c pause");
         Process.Start(start);
      }
   }
}