using System;

namespace c_sharp_odev_degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            byte v_byte = 5;    //1 byte  0 to 255
            sbyte v_sbyte = 5;  //1 byte  -128 to 127


            short v_short = 5;      //2 byte -32,768 to 32,767
            ushort v_ushort = 5;    //2 byte 0 to 65,535

            int v_int = 5;      //4 byte -2,147,483,648 to 2,147,483,647        
            uint v_uint = 5;    //4 byte 0 to 4,294,967,295
            long v_long = 5;    //8 byte -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong v_ulong = 5;  //8 byte 0 to 18,446,744,073,709,551,615

            Int16 v_int16 = 5;  //4 byte short
            Int32 v_int32 = 5;  //4 byte int
            Int64 v_int64 = 5;  //4 byte long


            float v_float = 5f;          //4 byte
            double v_double = 5d;        //8 byte  
            decimal v_decimal = 5m;      //16 byte  


            char v_char = 't';          //2 byte
            string v_string = "table";


            bool v_boolTrue = true;
            bool v_boolFalse = false;


            DateTime v_dateTime = DateTime.Now;


            object v_object1 = 't';
            object v_object2 = "table";
            object v_object3 = 5;
            object v_object4 = 5.5;


            string v_str1 = string.Empty;
            v_str1 = "table";

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;


            int v_integer1 = 5;
            int v_integer2 = 3;
            int v_integer3 = v_integer1 * v_integer2;

            bool v_bool1 = 2 > 1;


            string v_str10 = "10";
            int v_integer10 = 10;

            string v_newValue1 = v_str10 + v_integer10.ToString();
            int v_newValue2 = v_integer10 + Convert.ToInt32(v_str10);
            int v_newValue3 = v_integer10 + int.Parse(v_str10);

            string v_formattedDate1 = DateTime.Now.ToString("dd.MM.yyyy");
            string v_formattedDate2 = DateTime.Now.ToString("dd/MM/yyyy");
            string v_formattedDate3 = DateTime.Now.ToString("HH:mm");





            Console.WriteLine("Selected variable: "+ v_formattedDate2 + " " + v_formattedDate3 );



            
        }
    }
}
