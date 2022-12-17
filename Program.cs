namespace User19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            validfirstname firstname = new validfirstname();
            Console.WriteLine(firstname.validatefirstname("Charu"));

            validlastname lastname = new validlastname();
            Console.WriteLine(lastname.validatelastname("Varma"));

            validemail email = new validemail();
            Console.WriteLine(email.validateemail("Har@shin.com"));

            mobileformat mobile = new mobileformat();
            Console.WriteLine(mobile.validatemobilenumber("91 9876543210"));

            passwordrule1 rule1 = new passwordrule1();
            Console.WriteLine(rule1.validatePassWord1("harshini"));

            passwordrule2 rule2 = new passwordrule2();
            Console.WriteLine(rule2.validatePassWord2("Harshini"));
            
            passwordrule3 rule3 = new passwordrule3();
            Console.WriteLine(rule3.validatePassWord3("harshiN3"));

            passwordrule4 rule4 = new passwordrule4();
            Console.WriteLine(rule4.validatePassWord4("harshinI3@"));

            emailsamples samples = new emailsamples();
            Console.WriteLine(samples.validateallemails("har+sh3@in.com"));
        }
    }
}