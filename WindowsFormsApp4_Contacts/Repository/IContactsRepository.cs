using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4_Contacts.Repository
{
    interface IContactsRepository
    {
        DataTable SelectAll();//همان تیبل دیتایمان در اسکیوال منیجمنت را دقیقا همان شکلی چاپ میکند و نیاز به ورودی در اینجا ندارد
       
        DataTable SelectRow(int ContactID);//یه ردیف از تیبلمان را چاپ میکند کدام یک را ؟ ان یکی که کانتکت ایدی اش را دادیم

        DataTable Search(string SearchValue);
        
        bool Insert(string Name, string Family, string Number, string Email, string Addres);//اسم و نوع دیتا تایپ ها با توجه به اسم و نوع سطون های دیتا بیسمان به جز ان سطونی که خود دیتابیس زحمت مقدار دهیش رو میکشد. ان یکی که اوتو اینکریمنت است(ایدنتیفای اینکریمنت) است
       
        bool Update(int ContactID, string Name, string Family, string Number, string Email, string Addres);//به مشابه بالا ولی ایندفعه برای اپدیت نیاز داریم بدانیم کدام ردیف که با کانتکت ای دی قابل انتخاب است
       
        bool Delete(int ContactID);// دلیت میکند ان یکی را که کانتکت ایدی اش را دادیم

        //چرا بولین؟ چون اگر با موفقیت همراه بود ترو ریترن کند و اگر نه فالس ریترن کند

    }
}
