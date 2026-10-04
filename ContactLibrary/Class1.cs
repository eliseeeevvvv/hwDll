using System.Text.RegularExpressions;

namespace ContactLibrary
{
    public static class ContactValidator
    {
        public static bool ValidateName(string name)
        {
            return Regex.IsMatch(name, @"^[А-Яа-яЇїІіЄєҐґA-Za-z\s]+$");
        }

        public static bool ValidateAge(string age)
        {
            return Regex.IsMatch(age, @"^\d+$");
        }

        public static bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\+380\d{9}$");
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }
    }
}