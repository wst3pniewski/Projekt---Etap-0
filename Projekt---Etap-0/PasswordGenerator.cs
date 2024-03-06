using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator_hasel
{
    public class PasswordGenerator : UserControl
    {
        private List<Char> passwordCharList = new List<Char>();
        private readonly Random rng = new();
        private String generatedPassword;

        public String generatePassword(int password_length, Boolean isBigLetters, Boolean isSmallLetters, 
            Boolean isNumbers, Boolean isSpecialSigns)
        {
            passwordCharList.Clear();  
            
            if (password_length <= 5 ) 
            {
                throw new WrongPasswordLengthException("Hasło powinno mieć długosc co najmniej 6 znakow.");           
            }

            if (!isBigLetters && !isSmallLetters && !isNumbers && !isSpecialSigns) 
            {
                throw new AnyCheckBoxSelectedException("Przynajmniej jedna z opcji powinna zostać wybrana.");
            }
            if (isBigLetters)
            {
                this.addSignsToList(passwordCharList, "bigLetters");
            }
            if (isSmallLetters) 
            {
                this.addSignsToList(passwordCharList, "smallLetters");
            }
            if (isNumbers)
            {
                this.addSignsToList(passwordCharList, "numbers");
            }
            if (isSpecialSigns) 
            {
                this.addSignsToList(passwordCharList, "specialSigns");
            }

            for (int i = 1; i <= password_length; i++)
            {
                generatedPassword += passwordCharList[rng.Next(passwordCharList.Count)];
            }
            return generatedPassword;
        }

        private void addSignsToList(List<Char> givenList, String signsType)
        {
            switch (signsType)
            {
                case "smallLetters":
                    for (char j = 'a'; j <= 'z'; j++)
                    {
                        givenList.Add(j);
                    }
                    break;
                case "bigLetters":
                    for (char i = 'A'; i <= 'Z'; i++)
                    {
                        givenList.Add(i);
                    }
                    break;
                case "numbers":
                    for (char n = '0'; n <= '9'; n++)
                    {
                        givenList.Add(n);
                    }
                    break;
                case "specialSigns":
                    for (char s = '!'; s <= '/'; s++)
                    {
                        givenList.Add(s);
                    }
                    for (char s = ':'; s <= '@'; s++)
                    {
                        givenList.Add(s);
                    }
                    for (char s = '[';s<='`'; s++)
                    {
                        givenList.Add(s);
                    }
                    for (char s = '{'; s<= '~'; s++)
                    {
                        givenList.Add(s);
                    }
                    break;
            }
        }

    }
}
