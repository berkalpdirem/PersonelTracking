using Microsoft.VisualBasic.ApplicationServices;
using PersonelTracking_2_DLL.Managers;
using PersonelTracking_3_DAL.Concrete;
using PersonelTracking_3_DAL.Context;
using PersonelTracking_4_Entities.Abstract.Enums;
using PersonelTracking_4_Entities.Contrete;
using System.Windows.Forms;

namespace PersonelTracking_1_UI
{
    public partial class PersonelTracking : Form
    {

        EmployeeManager employeeManager;
        EmployeeDetailManager employeeDetailManager;
        private int selectionID;
        public PersonelTracking()
        {
            InitializeComponent();

            employeeManager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()), new EmployeeRepository(new AppDbContext()));
            employeeDetailManager = new EmployeeDetailManager(new GenericRepository<EmployeeDetail>(new AppDbContext()), new EmployeeDetailRepository(new AppDbContext()));
        }

        private void PersonelTracking_Load(object sender, EventArgs e)
        {
            //Medeni halin ilgili comboBoxa doldurulması
            MaritalStatus[] martialStatusValues = (MaritalStatus[])Enum.GetValues(typeof(MaritalStatus));
            gb_Employee_Register_MartialStatus_cb.DataSource = martialStatusValues;

            //Doğduğu şehir için şehir isimilerinin ilgili comboBoxlara doldurulması
            Cities[] birthCity = (Cities[])Enum.GetValues(typeof(Cities));
            gb_Employee_Register_LivingCity_cb.DataSource = birthCity;

            //Yaşadoğı şehir için şehir isimilerinin ilgili comboBoxlara doldurulması
            Cities[] livingCity = (Cities[])Enum.GetValues(typeof(Cities));
            gb_Employee_Register_BirthCity_cb.DataSource = livingCity;

            RefleshListBox();
        }
        #region Helper Methods
        private void RefleshListBox()
        {
            gb_Employee_Register_Employees_ListBox.Items.Clear();
            
            
            List<Employee> employeeList = employeeManager.GetAll();

            gb_Employee_Register_Employees_ListBox.Items.Clear();
            

            foreach (Employee employee in employeeList)
            {
                if (employee.dataStatus != DataStatus.SoftDeleted)
                {
                    MessageBox.Show("Test");
                    gb_Employee_Register_Employees_ListBox.Items.Add(employee.tcNo + " " + employee.name + " " + employee.surname);
                }
            }
        }

        #endregion
        private void gb_Employee_Register_Register_btn_Click(object sender, EventArgs e)
        {
            int tcNo = int.Parse(gb_Employee_Register_TcNo_tb.Text);
            string name = gb_Employee_Register_Name_tb.Text;
            string surName = gb_Employee_Register_Surname_tb.Text;
            MaritalStatus maritalStatus = (MaritalStatus)gb_Employee_Register_MartialStatus_cb.SelectedValue;
            Cities birthCity = (Cities)gb_Employee_Register_BirthCity_cb.SelectedValue;
            Cities livingCity = (Cities)gb_Employee_Register_LivingCity_cb.SelectedValue;
            DateTime birthDate = DateTime.Now;
            string motherName = gb_Employee_Register_FatherName_tb.Text;
            string fatherName = gb_Employee_Register_MotherName_tb.Text;

            MessageBox.Show(employeeManager.RegisterEmployee(tcNo, name, surName, maritalStatus, birthCity, livingCity, birthDate, motherName, fatherName));
            RefleshListBox();

        }

        private void gb_Employee_Register_Update_btn_Click(object sender, EventArgs e)
        {
            int tcNo = int.Parse(gb_Employee_Register_TcNo_tb.Text);
            string name = gb_Employee_Register_Name_tb.Text;
            string surName = gb_Employee_Register_Surname_tb.Text;
            MaritalStatus maritalStatus = (MaritalStatus)gb_Employee_Register_MartialStatus_cb.SelectedValue;
            Cities birthCity = (Cities)gb_Employee_Register_BirthCity_cb.SelectedValue;
            Cities livingCity = (Cities)gb_Employee_Register_LivingCity_cb.SelectedValue;
            DateTime birthDate = DateTime.Now;
            string motherName = gb_Employee_Register_FatherName_tb.Text;
            string fatherName = gb_Employee_Register_MotherName_tb.Text;



            MessageBox.Show(employeeManager.UpdateEmployee(selectionID, tcNo, name, surName, maritalStatus, birthCity, livingCity, birthDate, motherName, fatherName));

            gb_Employee_Register_Update_btn.Enabled = false;
            gb_Employee_Register_Delete_btn.Enabled = false;
            RefleshListBox();
        }

        private void gb_Employee_Register_Delete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(employeeManager.DeleteEmployee(1));
            gb_Employee_Register_Update_btn.Enabled = false;
            gb_Employee_Register_Delete_btn.Enabled = false;
            RefleshListBox();
        }
        private void gb_Employee_Register_Selection_btn_Click(object sender, EventArgs e)
        {
            var selectedItem = gb_Employee_Register_Employees_ListBox.SelectedItem;

            if (selectedItem != null)
            {
                int selectedEmployeesTC = int.Parse((selectedItem.ToString().Split(' '))[0]);
                Employee selectedEmployee = employeeManager.GetEmployee(selectedEmployeesTC);
                selectionID = selectedEmployee.Id;

                gb_Employee_Register_TcNo_tb.Text = selectedEmployee.tcNo.ToString();
                gb_Employee_Register_Name_tb.Text = selectedEmployee.name;
                gb_Employee_Register_Surname_tb.Text = selectedEmployee.surname;

                int employeeId = selectedEmployee.Id;
                EmployeeDetail selectedEmployeeDetail = employeeDetailManager.GetById(employeeId);

                gb_Employee_Register_MartialStatus_cb.Text = selectedEmployeeDetail.maritalStatus.ToString();
                gb_Employee_Register_BirthCity_cb.Text = selectedEmployeeDetail.birthCity.ToString();
                gb_Employee_Register_LivingCity_cb.Text = selectedEmployeeDetail.livingCity.ToString();
                gb_Employee_Register_BirthDate_tb.Text = selectedEmployeeDetail.birthDate.ToString();
                gb_Employee_Register_FatherName_tb.Text = selectedEmployeeDetail.fatherName.ToString();
                gb_Employee_Register_MotherName_tb.Text = selectedEmployeeDetail.motherName.ToString();

                gb_Employee_Register_Update_btn.Enabled = true;
                gb_Employee_Register_Delete_btn.Enabled = true;
            }
        }
    }
}