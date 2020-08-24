using System;
using System.Collections.Generic;
using System.Text;

namespace Morse
{
    public class MorseDictionary
    {
        public Dictionary<char, string> morseDictionary = new Dictionary<char, string>();

        public MorseDictionary()
        {
            morseDictionary.Add('A', ".-");
            morseDictionary.Add('B', "-...");
            morseDictionary.Add('C', "-.-.");
            morseDictionary.Add('D', "-..");
            morseDictionary.Add('E', ".");
            morseDictionary.Add('F', "..-.");
            morseDictionary.Add('G', "--.");
            morseDictionary.Add('H', "....");
            morseDictionary.Add('I', "..");
            morseDictionary.Add('J', ".---");
            morseDictionary.Add('K', "-.-");
            morseDictionary.Add('L', ".-..");
            morseDictionary.Add('M', "--");
            morseDictionary.Add('N', "-.");
            morseDictionary.Add('O', "---");
            morseDictionary.Add('P', ".--.");
            morseDictionary.Add('Q', "--.-");
            morseDictionary.Add('R', ".-.");
            morseDictionary.Add('S', "...");
            morseDictionary.Add('T', "-");
            morseDictionary.Add('U', "..-");
            morseDictionary.Add('V', "...-");
            morseDictionary.Add('W', ".--");
            morseDictionary.Add('X', "-..-");
            morseDictionary.Add('Y', "-.--");
            morseDictionary.Add('Z', "--..");
            morseDictionary.Add('1', ".----");
            morseDictionary.Add('2', "..---");
            morseDictionary.Add('3', "...--");
            morseDictionary.Add('4', "....-");
            morseDictionary.Add('5', ".....");
            morseDictionary.Add('6', "-....");
            morseDictionary.Add('7', "--...");
            morseDictionary.Add('8', "---..");
            morseDictionary.Add('9', "----.");
            morseDictionary.Add('0', "-----");
            morseDictionary.Add('.', "|");
            morseDictionary.Add(' ', "|");
        }
    }
}
