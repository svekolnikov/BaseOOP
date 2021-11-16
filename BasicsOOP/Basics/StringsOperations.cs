using System;
using System.Collections.Generic;
using System.IO;

namespace BasicsOOP.Basics
{
    public class StringsOperations
    {
        public string Reverse(string str)
        {
            var result = "";

            for (var i = str.Length - 1; i >= 0; --i)
            {
                result += str[i];
            }

            return result;
        }

        public List<string> GetEmailsFromContacts(string contactsPath)
        {
            var emails = new List<string>();

            foreach (var line in GetStringLine(contactsPath))
            {
                var s = line;
                SearchMail(ref s);
                emails.Add(s);
            }

            return emails;
        }

        public void SaveEmails(List<string> emails, string path)
        {
            if (emails == null) throw new ArgumentNullException(nameof(emails));
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or whitespace.", nameof(path));
            }

            if (emails.Count == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(emails), "Список пуст");
            }

            File.WriteAllLinesAsync(path, emails);

            Console.WriteLine("Сохранено.");
        }

        private static void SearchMail(ref string s)
        {
            s = s.Split("&")[1].Trim();
        }

        private IEnumerable<string> GetStringLine(string path)
        {
            var sr = new StreamReader(path);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
            sr.Close();
        }
    }
}
