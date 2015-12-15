namespace _03.StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private string concatenatedStrings;

        public StringDisperser(params string[] strings)
        {
            this.ProcessInputStrings(strings);
        }

        public string ConcatenatedStrings
        {
            get
            {
                return this.concatenatedStrings;
            }
        }

        public static bool operator ==(StringDisperser a, StringDisperser b)
        {
            return StringDisperser.Equals(a, b);
        }

        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            var other = (StringDisperser)obj;
            return object.Equals(this.concatenatedStrings, other.concatenatedStrings);
        }

        public override int GetHashCode()
        {
            return this.concatenatedStrings.GetHashCode();
        }

        public object Clone()
        {
            return new StringDisperser(this.concatenatedStrings);
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.concatenatedStrings.Length; i++)
            {
                yield return this.concatenatedStrings[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(StringDisperser other)
        {
            return string.Compare(this.concatenatedStrings, other.concatenatedStrings, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return this.concatenatedStrings;
        }

        private void ProcessInputStrings(string[] inputStrings)
        {
            var result = new StringBuilder();
            foreach (var str in inputStrings)
            {
                result.Append(str);
            }

            this.concatenatedStrings = result.ToString();
        }
    }
}