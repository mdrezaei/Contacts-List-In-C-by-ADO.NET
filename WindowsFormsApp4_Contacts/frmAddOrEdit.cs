using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4_Contacts.Repository;//این و پایینیش رو یوزینگ کردیم قبلا توضیح دادم
using WindowsFormsApp4_Contacts.Services;

namespace WindowsFormsApp4_Contacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository Repository;//نام تکراری در دو کلاس غیر هم نام
        public int ContactID = 0;// چون صفر به عنوان کانتکت ای دی نداریم پس سنجه خوبی هستش تا توی فرم لود مشخص کنیم اسمش چی باشه

        public frmAddOrEdit()
        {
            InitializeComponent();
            Repository = new ContactsRepository();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (ContactID==0)
            {
                this.Text = "افزودن مخاطب جدید";//دیس یعنی <<این>> فرم . چرا توی پراپرتی نبردیمش؟چون اگه میخواستیم ویرایش کنیم اسمش رو بشه گذاشت ویرایش
            }
            else
            {
                this.Text = "ویرایش";
                DataTable DT = new DataTable();
                DT = Repository.SelectRow(ContactID);//دیتا تیبل هم مثل دیتا گرید ویو است همون قابلیت ها را دارد
                txtName.Text = DT.Rows[0][1].ToString();//تکست نیم که همون تکست باکس اسم ما هست . دات تکس هم که یعنی متن درون ان . مساوی با دیتا تیبلی که اطلاعات توش هست . دات روو هم یعنی خب کدوم ردیفش و از اونجای که کلا یک ردیف واردش کردیم اولین ردیف یعنی ردیف صفرم . دوین رایه هم که بلافاصله بعد اندیس رو هست اندیس سطون هست که اسم ما در دومین سطون یعنی سطون یکم است . و در اخر دات تو استرینگ چون کر هستند
                txtFamily.Text = DT.Rows[0].ItemArray[2].ToString();//میشه از دات ایتم اری هم استفاده کرد که همون شماره اندیس سطون رو میزاریم
                txtNumber.Text = DT.Rows[0][3].ToString();
                txtEmail.Text = DT.Rows[0][4].ToString();
                txtAddres.Text = DT.Rows[0][5].ToString();
            }
        }

        bool ValidationOfTxt()
        {
            bool Validation = true;

            if (txtName.Text == "" || txtFamily.Text == "" || txtNumber.Text == "")
            {
                Validation = false;
                MessageBox.Show("جاهای خالی که با ستاره مشخص شده است را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);//استرینگ اولی متن مسیج باکس هست و استرینگ دوم کپشن یا تیتر مسیجباکس هست و با حرف ویرگول اگلیسی جدا میشوند و بعد میتوان با نوشتن مسیجباکس به باتن ها ایکون ها و اپشن هاش که از نوع اینام هستند دسترسی پیدا کرد مانند روبه رو
            }

            return Validation;//ریترن هرجا باشه حتی در بلاک ایف هم باشه از متد خارج میشود
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidationOfTxt()==true)
            {
                bool isSuccess;
                if (ContactID==0)
                {
                    isSuccess = Repository.Insert(txtName.Text, txtFamily.Text, txtNumber.Text, txtEmail.Text, txtAddres.Text);//متد اینسرت بولین برمیگردونه میریزیمش تو بولین. بولین ها موقع نامگذاری اکثرا اول اسمشون یک ایز کوچیک دارن
                }
                else
                {
                    isSuccess = Repository.Update(ContactID, txtName.Text, txtFamily.Text, txtNumber.Text, txtEmail.Text, txtAddres.Text);
                }
            
                if(isSuccess==true)
                {
                    MessageBox.Show("باموفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK; //هر فرمی که با شو دیالوگ باز شده  یک دیالوگ ریزالت دارد و ما فقط مقدار دهیش میکنیم. بعد در فرم های دیگر میاییم و با صدا زدن نام فرم ان و دات دیالوگ ریزالت مقدارش را میگیریم . یک جواب دیالوگ . ولی فقط فرم هایی دیالوگ ریزالت دارند که به صورت شودیالوگ باز شده باشند.در اینجا یعنی دیالوگ ریزالت برابر است با جوابی که باید به دیالوگ ریزالت بدهد اوکی است . بعد چون این فرم با شو دیالوگ باز شده منتظر ریزالت هست تا خود کار بسته شه و باید ریزالت بهش بدیم تا بسته شه 
                    //حالا برمیگردیم ان جایی که این فرم را با شودیالوگ باز کردیم و یک ایف درست میکنیم
                }
                else
                {
                    MessageBox.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.OK;//چرا اینجا اوردیم چون که به ما ریزالت رو برگردونه تا فرم بسته شه خودش و چرا اوکی دادیم چون توی فرم یک با شرط دیالوگ ریزالت اوکی هست که رفرش میکنه 
                }
            }
        }
    }
}
