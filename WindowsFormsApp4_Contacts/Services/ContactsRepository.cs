using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4_Contacts.Repository;//اینجا یوزینگ شده است
using System.Data.SqlClient;//برای کار با اسکیوال

namespace WindowsFormsApp4_Contacts.Services//فضای نام دات اسم فولدر به این شکل فقط در این فولدر قابل دسترسی خواهد بود این ایتم درون این فضای نام مگر انکه این فضای نام و دات و نام فولدرش یوزینگ شود یا دات و نام فولدرش پاک شود
{
    class ContactsRepository : IContactsRepository//این اینتر فیس فضای نامش را باید یوزینگ میکردیم و یا در جلوی فضای نام این اینتر فیس نوشته شده است دات ریپوزیتوری که اشاره به فولدری که در ان است دارد و اگر دات ریپوزیتوری یعنی نام ان فولدر را پاک کنیم برای تمام این نیم اسپیس قابل دسترسی میشود
    {
        private string ConnectionString = @"Data Source=DESKTOP-SBV0NOJ\SQLSERVER19FIRST;Initial Catalog=Contacts_DB;User ID=sa;Password=Mohamad 13$0"; //"Data Source=SQLSERVER19FIRST;Initial Catalog=Contacts_DB;Integrated Security=true";// User ID=xxx;Password=xxx به ترتیب اولی به معنای دیتا بیس در چه مسیری است درکدام سرور و هاست است . دات به معنای لوکال است.میتواند ایپی و یا دامنه هم باشد.اینیشیال کتالوگ به معنای کدام بانک(کدام دیتابیس) با کدام اسم. بعدی به معنای استفاده از خود اجازه ویندوز است که چگونه اجازه ورود دارد یا خیر گاها یوزر و پسورد میباشد به این صورت که 
        //پرایویت به این دلیل است که سطح دسترسی ندهد

        public bool Delete(int ContactID)
        {
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);
            try
            {
                string Query = "delete from ContactInfoDesign where ContactID = @ContactID";
                SqlCommand Command = new SqlCommand(Query, ConnectionDB);
                Command.Parameters.AddWithValue("@ContactID", ContactID);
                ConnectionDB.Open();
                Command.ExecuteNonQuery();
                return true;
            }
            catch 
            {

                return false;
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        public bool Insert(string Name, string Family, string Number, string Email, string Addres)
        {
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);//چرا اس کیو ال کانکشن را گذاشتیم بیرون ترای ؟ چون که بشود اس کیو ال کانکشن را دستور به باز شدنش هم در ترای بدهیم و دستور به بسته شدنش را در فاینالی .یعنی بتوانیم در تمام متدمان با نام اس کیو ال کانکشن ان را در کل متد و در کل ترای کش صدا کنیم  

            try
            {
                string Query = "insert into ContactInfoDesign(Name,Family,Number,Email,Addres) values(@Name,@Family,@Number,@Email,@Addres)";//@ دادیم که پارامتر شن که یکی جای اسم هم اگه کوئری زد اتفاقی نیفته
                SqlCommand Command = new SqlCommand(Query, ConnectionDB);//اس کیو ال کامند تنها دستوری هست که در بانک اجازه تعغیرات دارد. خودش درب دیتا بیس را باز و بسته نمیکند
                Command.Parameters.AddWithValue("@Name", Name);//میگیم ولیو را به پارامتر های کوئری مان در دستور کامند اضافه کند که یک پارامتر میگیرد و دوم مقدار برای ان پارامتر میگیرد
                Command.Parameters.AddWithValue("@Family", Family);
                Command.Parameters.AddWithValue("@Number", Number);
                Command.Parameters.AddWithValue("@Email", Email);
                Command.Parameters.AddWithValue("@Addres", Addres);
                ConnectionDB.Open();//چون اس کیو ال کامند درب را باز نمیکند ما اس کیو ال کانکشن خودمان را دستی دستور به باز شدنش میدهیم. یادمان باشد درب هارا ببندیم چون موجب کندی برنامه میشود 
                Command.ExecuteNonQuery();//دستور اجرای اس کیو ال کامند را میدهیم
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                ConnectionDB.Close();//درب درب دیتا بیس را میبندد چرا در فاینالی ؟ چون امکان دارد در ترای قبل از بسته شدن درب خطا بگیریم و یا هیچ وقت به کش فراخوانده نشویم پس در فاینالی 
            }
        }

        public DataTable Search(string SearchValue)
        {
            string Query = "select * from ContactInfoDesign where Name like @SearchValue or Family like @SearchValue or Number like @SearchValue or Email like @SearchValue or Addres like @SearchValue";//لازم نیست و نباید پارامتر ها درون کتیشن باشند با حرف ان کنارشون برای ان ور کر شدن مشابه زمانی که کیئری را درون خود اس کیو ال سرور مینوشتیم 
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);
            SqlDataAdapter AdapterSearch = new SqlDataAdapter(Query, ConnectionDB);
            AdapterSearch.SelectCommand.Parameters.AddWithValue("@SearchValue", "%" + SearchValue + "%");//مانند کامند دات پارامترز دات اد ویف ولیو است و از انجا که درصد را اینجا بهش اضافه میکنیم در کوئری درصد نمیزاریم تا مشکل ایجاد نکند
            DataTable DataTableSearch = new DataTable();           
            AdapterSearch.Fill(DataTableSearch);
            return DataTableSearch;
        }

        public DataTable SelectAll()
        {
            string Query = "Select * From ContactInfoDesign";//خط دستور برای کوئری دیتا بیس
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);//اسکیوال کانکشن کلاسی که نمونه سازی میکنیم برای ورود به دیتا بیس و ادرس ورودیمون رو به این کلاس میدیم و از اون یک نمونه میسازیم. در پرانتز این کلاس ادرس و مشخصات لازم برای ورود رو میدیم . ادرس دیتا بیس . اسم دیتا بیس . مجوز ورود به دیتا بیس. در اینجا ما قبلا مشخصات را در کانکشن استرین در ان بالا زخیره کرده ایم
            SqlDataAdapter AdapterSelectAll = new SqlDataAdapter(Query, ConnectionDB);//اسکیوال دیتا اداپتر کلاسی هست که از در ورودی که به واسطه اسکیوال کانشکن ساختیم وارد میشود و کوئری را که قبلا تهیه کردیم را اجرا میکند و نتایج را به دست می اورد . از اون نمونه سازی میکنیم و در پرانتز ان ابتدا کوئری مدنظر و سپس درب ورود به دیتا بیسمان را که قبلا از کلاس اسکیوال کانکشن نمونه سازی کردیم را به ان میدهیم که چگونه وارد و به کجا وارد و کویری را یرای کدام دیتا بیس به اجرا در اورد. خودش درب دیتابیس را باز و بسته میکند نیازی به دستور دیگری برای باز و بسته کردن نیست
            DataTable DataTableSelectAll = new DataTable();//همان تیبل دیتایمان در اسکیوال منیجمنت را دقیقا همان شکلی چاپ میکند و چون نیاز داریم که اطلاعاتی را که به واسطه اسکیوال دیتا اداپتری که نمونه سازی کردیم را در جایی پ چاپ کنیم یک دیتا تیبل را نمونه سازی میکنیم در اینجا
            //ConnectionDB.Open();//این کد در اینجا احتیاجی بهش نیست چون خود اسکیوال دیتا اداپتر درب کانکشن را باز و بسته میکند . خودش حاوی این دستورات است
            AdapterSelectAll.Fill(DataTableSelectAll);// حال در اینجا اسکیوال دیتا اداپتری که نمونه سازی کردیم و به اطلاعات ما دست پیدا کرد را صدا میکنیم و با دستور دات فیل میگوییم که پرانتزش را از اطلاعاتی که به دست اورده است پر کند . در پرانتزش هم چیزی که باید و میتواند از اطلاعات ما پر شود را قرار میدهیم که میشود دیتا تیبلمان که قبلا هم نمونه سازی اش کرده ایم
            return DataTableSelectAll;//حالا اطلاعات را ریترن کن. اطلاعات کجاست در دیتا تیبلمان و باید هم دیتا تیبل ریترن کند چون این متد باید دیتا تیبل ریترن کند
        }

        public DataTable SelectRow(int ContactID)
        {
            string Query = $"Select * From ContactInfoDesign where ContactID={ContactID}";
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);           
            DataTable DataTableSelectAll = new DataTable();
            SqlDataAdapter AdapterSelectAll = new SqlDataAdapter(Query, ConnectionDB);
            AdapterSelectAll.Fill(DataTableSelectAll);
            return DataTableSelectAll;
        }

        public bool Update(int ContactID, string Name, string Family, string Number, string Email, string Addres)//چرا این کانتکت ای دی داره ولی اینسرت نداشت؟ چون  این باید بدونه کدووووم رو اپدیت کنه
        {
            SqlConnection ConnectionDB = new SqlConnection(ConnectionString);   

            try
            {
                string Query = "update ContactInfoDesign set Name=@Name, Family=@Family, Number=@Number, Email=@Email, Addres=@Addres where ContactID=@ContactID";
                SqlCommand Command = new SqlCommand(Query, ConnectionDB);
                Command.Parameters.AddWithValue("@ContactID", ContactID);
                Command.Parameters.AddWithValue("@Name", Name);
                Command.Parameters.AddWithValue("@Family", Family);
                Command.Parameters.AddWithValue("@Number", Number);
                Command.Parameters.AddWithValue("@Email", Email);
                Command.Parameters.AddWithValue("@Addres", Addres);
                ConnectionDB.Open(); 
                Command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                ConnectionDB.Close(); 
            }
        }

    }
}
