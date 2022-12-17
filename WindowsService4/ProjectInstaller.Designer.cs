namespace WindowsService4
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller4 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller4 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller4
            // 
            this.serviceProcessInstaller4.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller4.Password = null;
            this.serviceProcessInstaller4.Username = null;
            // 
            // serviceInstaller4
            // 
            this.serviceInstaller4.Description = "A Windows Service for Testing";
            this.serviceInstaller4.DisplayName = "Windows Service 4 - DN";
            this.serviceInstaller4.ServiceName = "WindowsService4";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller4,
            this.serviceInstaller4});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller4;
        private System.ServiceProcess.ServiceInstaller serviceInstaller4;
    }
}