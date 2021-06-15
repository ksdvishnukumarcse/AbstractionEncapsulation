using System;

namespace AbstractionEncapsulation
{
    /// <summary>
    /// Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            #region Encapsulation
            Console.WriteLine("Encapsulation");
            Employee.SetEmployee("Vishnu", 18);
            Console.WriteLine($"Employee name is {Employee.GetName()}");
            Console.WriteLine($"Employee age is {Employee.GetAge()}");
            Console.WriteLine($"{Employee.GetEmployeeDetails()}");
            #endregion

            #region Abstraction
            Console.WriteLine();
            Console.WriteLine("Abstraction");

            AbstractCustomer basicCustomer = new BasicCustomer("B1", CustomerType.Basic);
            Console.WriteLine(basicCustomer.GetCustomerName());

            AbstractCustomer premiumCustomer = new PremiumCustomer("P1", CustomerType.Premium);
            Console.WriteLine(premiumCustomer.GetCustomerName());

            AbstractCustomer walkinCustomer = new WalkInCustomer("W1", CustomerType.WalkIn);
            Console.WriteLine(walkinCustomer.GetCustomerName());

            #endregion
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Employee
    /// </summary>
    public class Employee
    {
        private static string _name;
        private static int _age;

        /// <summary>
        /// Sets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        public static void SetEmployee(string name, int age)
        {
            _name = name;
            _age = age;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>string</returns>
        public static string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <returns>int</returns>
        public static int GetAge()
        {
            return _age;
        }

        /// <summary>
        /// Gets the employee details.
        /// </summary>
        /// <returns>string</returns>
        public static string GetEmployeeDetails()
        {
            return $"Employee Name is {_name} nad age is {_age}";
        }
    }

    /// <summary>
    /// AbstractCustomer
    /// </summary>
    public abstract class AbstractCustomer
    {
        string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCustomer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public AbstractCustomer(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns>string</returns>
        public virtual string GetCustomerName()
        {
            return $"Customer Name is {_name}";
        }
    }

    /// <summary>
    /// BasicCustomer
    /// </summary>
    /// <seealso cref="AbstractionEncapsulation.AbstractCustomer" />
    public class BasicCustomer : AbstractCustomer
    {
        private readonly CustomerType _customerType;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicCustomer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="customerType">Type of the customer.</param>
        public BasicCustomer(string name, CustomerType customerType) : base(name)
        {
            _customerType = customerType;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string GetCustomerName()
        {
            return $"{ base.GetCustomerName() } and Customer Type is {_customerType}";
        }
    }

    /// <summary>
    /// PremiumCustomer
    /// </summary>
    /// <seealso cref="AbstractionEncapsulation.AbstractCustomer" />
    public class PremiumCustomer : AbstractCustomer
    {
        private readonly CustomerType _customerType;

        /// <summary>
        /// Initializes a new instance of the <see cref="PremiumCustomer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="customerType">Type of the customer.</param>
        public PremiumCustomer(string name, CustomerType customerType) : base(name)
        {
            _customerType = customerType;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string GetCustomerName()
        {
            return $"{ base.GetCustomerName() } and Customer Type is {_customerType}";
        }
    }

    /// <summary>
    /// WalkInCustomer
    /// </summary>
    /// <seealso cref="AbstractionEncapsulation.AbstractCustomer" />
    public class WalkInCustomer : AbstractCustomer
    {
        private readonly CustomerType _customerType;

        /// <summary>
        /// Initializes a new instance of the <see cref="WalkInCustomer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="customerType">Type of the customer.</param>
        public WalkInCustomer(string name, CustomerType customerType) : base(name)
        {
            _customerType = customerType;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string GetCustomerName()
        {
            return $"{ base.GetCustomerName() } and Customer Type is {_customerType}";
        }
    }

    /// <summary>
    /// CustomerType
    /// </summary>
    public enum CustomerType
    {
        Basic,
        Premium,
        WalkIn
    }
}
