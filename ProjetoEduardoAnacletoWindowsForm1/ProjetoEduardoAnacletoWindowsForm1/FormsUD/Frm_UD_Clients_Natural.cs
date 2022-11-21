using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsUD
{
    public partial class Frm_UD_Clients_Natural : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_UD_Master
    {
        public Frm_UD_Clients_Natural(Clients client)
        {
            InitializeComponent();
            PopulateCamps(client);
        }

        public void PopulateCamps(Clients client)
        {
            try
            {
                PopulateCampsPerson(client);
                PopulateCampsAddress(client);
                PopulateCampsIdentification(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void PopulateCampsPerson(Clients client)
        {
            edt_firstName.Text = client.firstName;
            edt_middleName.Text = client.middleName;
            edt_lastName.Text = client.lastName;
            edt_email.Text = client.email;
            edt_age.Text = client.age.ToString();
            medt_dob.Text = client.dateOfBirth.ToString();
            medt_regNumber.Text = client.dateOfBirth.ToString();


            if (client.gender == 1)
                rbtn_male.Checked = true;
            else if (client.gender == 2)
                rbtn_female.Checked = true;
            else if (client.gender == 3)
                rbtn_otherGender.Checked = true;

            medt_phone1.Text = (client.phoneNumber1);
            medt_phone2.Text = (client.phoneNumber2);
            medt_phone3.Text = (client.phoneNumber3);

            cbox_phone1.SelectedItem = client.phoneClass1;
            cbox_phone2.SelectedItem = client.phoneClass2;
            cbox_phone3.SelectedItem = client.phoneClass3;
        }

        public void PopulateCampsAddress(Clients client)
        {
            var auxCountryName = client.address.city.state.country.countryName;
            cbox_country.SelectedValue.Equals(auxCountryName);

            var auxStateName = client.address.city.state.stateName;
            cbox_state.SelectedValue.Equals(auxStateName);
            cbox_state.DataSource.Equals(auxCountryName);

            var auxCityName = client.address.city.cityName;
            cbox_city.DataSource.Equals(auxCityName);
            cbox_city.SelectedValue.Equals(auxCityName);

            medt_zipCode.Text = client.address.zipCode;
            edt_street.Text = client.address.streetName;
            edt_district.Text = client.address.district;
            cbox_homeType.SelectedValue = client.address.homeType;
            edt_complement.Text = client.address.complement;
        }

        public void PopulateCampsIdentification(Clients client)
        {
            edt_id.Text = client.id.ToString();
            mbox_dateCreated.Text = client.dateOfCreation.ToString();
            mbox_dateUpdated.Text = client.dateOfLastUpdate.ToString();
        }

        public override void Update()
        {
            
            base.Update();
        }
    }
}
