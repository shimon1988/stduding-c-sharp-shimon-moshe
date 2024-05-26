using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace stduding_c_sharp_shimon_moshe.Object_Learnnig
{
    public class ObjectTemplate
    {
        //properties - שדות/תכונות
        public int intProperty = 10;

        public string stringProperty = "some string";

        public bool boolProperty = false;

        //change bool value
        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }
        //change string value
        public void ChangeString(string value)
        {
            stringProperty = value;
        }
        //change int value
        public void ChangeInt(int value)
        {
            intProperty = value;
        }




    }

    public class TestBasicObject
    {

        public static void Demo()
        {
            ObjectTemplate template1 = new ObjectTemplate();
            ObjectTemplate template3 = new ObjectTemplate();


            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.boolProperty = true;
            template1.stringProperty = "another string";
            template1.intProperty = 20;
            Console.WriteLine("Template 1 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template1.intProperty, template1.stringProperty, template1.boolProperty);
            //tamplate3 print function properties
            template3.boolProperty = false;
            template3.stringProperty = "third string";
            template3.intProperty = 900;

            Console.WriteLine("Template 3 = intProperty = {0} , string property = {1}, boolProperty ={2} "
                , template3.intProperty, template3.stringProperty, template3.boolProperty);
            ObjectTemplate template2 = new ObjectTemplate();

            template2.ChangeString("my change!");
            template2.ChangeInt(400);
            template2.ToggleBoolProperty();
            Console.WriteLine("Template 2 = intProperty = {0} , string property = {1}, boolProperty ={2} "
               , template2.intProperty, template2.stringProperty, template2.boolProperty);

           
        }

        

            

    }
}
