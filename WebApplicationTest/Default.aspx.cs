using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Drawing;
using DataAccessObjects;
using WebApplicationTest.ServiceMath;
using WebApplicationTest.ServicePerson;

namespace WebApplicationTest
{
    public partial class _Default : Page
    {
        IServiceAddition additionClient = new ServiceAdditionClient();
        IServicePerson personClient = new ServicePersonClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            FillNameList();
            
        }

        private void calculateResult() 
        {
            try
            {
                int result = additionClient.Addition(getIntValue(Value1.Text), getIntValue(Value2.Text));
                LabelResult.Text = result.ToString();
            }
            catch (Exception) {
                LabelResult.ForeColor = Color.Red;
                LabelResult.Text = "Falsche Eingabe";
            }
            
            
        }

        private int getIntValue(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception) {
                throw new Exception();
            }
        }

        protected void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateResult();
        }

        protected void ButtonNameInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                Person person = new Person() { LastName = NameTextBox.Text, FirstName = FirstNameTextBox.Text };
                personClient.AddPerson(person);
            }
            FillNameList();
        }

        protected void ButtonNameRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                Person person = new Person() { LastName = NameTextBox.Text, FirstName = FirstNameTextBox.Text };
                personClient.RemovePerson(person);
            }
            FillNameList();
            
        }

        private void FillNameList() {
            NameListBox.Items.Clear();
            IList<Person> personList = personClient.GetPersonList();
            foreach (Person person in personList) {
                NameListBox.Items.Add(person.LastName + " " + person.FirstName);
            }

        }
    }
}