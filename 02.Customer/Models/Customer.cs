namespace _02.Customer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private IList<Payment> payments = new List<Payment>();

        public Customer(
            string firstName,
            string middleName,
            string lastName,
            long id,
            string permanentAddress,
            string mobilePhone,
            string email,
            CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = customerType;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public long Id { get; private set; }

        public string PermanentAddress { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public CustomerType CustomerType { get; private set; }

        public IEnumerable<Payment> Payments
        {
            get
            {
                return this.payments;
            }
        }

        public static bool operator ==(Customer a, Customer b)
        {
            return Customer.Equals(a, b);
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public void AddPayment(params Payment[] payment)
        {
            foreach (var pmnt in payment)
            {
                this.payments.Add(pmnt);
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            if (other != null)
            {
                return object.Equals(this.Id, other.Id);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            var newCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.CustomerType);

            foreach (var payment in this.payments)
            {
                newCustomer.AddPayment(payment);
            }

            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            var comparator = string.Compare($"{this.FirstName} {this.MiddleName} {this.LastName}", $"{other.FirstName} {other.MiddleName} {other.LastName}", StringComparison.Ordinal);

            return comparator == 0 ? this.Id.CompareTo(other.Id) : comparator;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"{this.FirstName} {this.LastName}, EGN: {this.Id}, Email: {this.Email}");
            result.AppendLine($"Payments: {(this.payments.Count > 0 ? string.Join(", ", this.payments) : "N/A")}");
            return result.ToString().Trim();
        }
    }
}