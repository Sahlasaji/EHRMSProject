using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHRMSProject
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }
        private LoginPage loginPage = new LoginPage();

        private DashboardPage dashboardPage = new DashboardPage();

        private PatientRegistrationPage patientRegistrationPage = new PatientRegistrationPage();

        private PatientProfilePage patientProfilePage = new PatientProfilePage();

        private EHRRecordsManagementPage eHRRecordsManagementPage = new EHRRecordsManagementPage();

        private AppointmentSchedulingPage appointmentSchedulingPage = new AppointmentSchedulingPage();

        private MedicationManagementPage medicationManagementPage = new MedicationManagementPage();

        private BillingAndInsurancePage billingAndInsurancePage = new BillingAndInsurancePage();

        private ReportingPage reportingPage = new ReportingPage();

        private AuditTrailPage auditTrailPage = new AuditTrailPage();

        private UserManagementPage userManagementPage = new UserManagementPage();

        private SettingsPage settingsPage = new SettingsPage();

        private HelpAndSupportPage helpAndSupportPage = new HelpAndSupportPage();

        private void userLoginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPage.MdiParent = this;
            loginPage.Show();
            loginPage.Activate();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboardPage.MdiParent = this;
            dashboardPage.Show();
            dashboardPage.Activate();
        }

        private void patientRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientRegistrationPage.MdiParent = this;
            patientRegistrationPage.Show();
            patientRegistrationPage.Activate();
        }

        private void patientProfilePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientProfilePage.MdiParent = this;
            patientProfilePage.Show();
            patientProfilePage.Activate();
        }

        private void eHRRecordsManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eHRRecordsManagementPage.MdiParent = this;
            eHRRecordsManagementPage.Show();
            eHRRecordsManagementPage.Activate();
        }

        private void appointmentSchedulingPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointmentSchedulingPage.MdiParent = this;
            appointmentSchedulingPage.Show();
            appointmentSchedulingPage.Activate();
        }

        private void medicationManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicationManagementPage.MdiParent = this;
            medicationManagementPage.Show();
            medicationManagementPage.Activate();
        }

        private void billingAndInsurancePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingAndInsurancePage.MdiParent = this;
            billingAndInsurancePage.Show();
            billingAndInsurancePage.Activate();
        }

        private void reportingPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportingPage.MdiParent = this;
            reportingPage.Show();
            reportingPage.Activate();
        }

        private void auditTrailPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auditTrailPage.MdiParent = this;
            auditTrailPage.Show();
            auditTrailPage.Activate();
        }

        private void userManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagementPage.MdiParent = this;
            userManagementPage.Show();
            userManagementPage.Activate();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsPage.MdiParent = this;
            settingsPage.Show();
            settingsPage.Activate();
        }

        private void helpAndSupportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpAndSupportPage.MdiParent = this;
            helpAndSupportPage.Show();
            helpAndSupportPage.Activate();
        }
    }
}
