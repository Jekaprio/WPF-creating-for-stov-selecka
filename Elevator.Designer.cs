﻿
namespace Селецька
{
    partial class Перегляд
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Перегляд));
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.webView2 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            resources.ApplyResources(this.webControl1, "webControl1");
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Name = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.InputMsgFilter = null;
            this.webView1.ObjectForScripting = null;
            this.webView1.Title = null;
            this.webView1.UnloadDelay = 0;
            this.webView1.Url = resources.GetString("webView1.Url");
            // 
            // webView2
            // 
            this.webView2.InputMsgFilter = null;
            this.webView2.ObjectForScripting = null;
            this.webView2.Title = null;
            // 
            // Перегляд
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webControl1);
            this.DrawerBackgroundWithAccent = true;
            this.Name = "Перегляд";
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private EO.WebBrowser.WebView webView2;
    }
}