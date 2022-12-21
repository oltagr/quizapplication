using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuiz
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "Kur u themelua Kolegji Universum";
            questions[0, 1] = "Tetor,2005";
            questions[0, 2] = "Mars,2006";
            questions[0, 3] = "*Mars,2005";
            questions[0, 4] = "Janar,2007";
            //
            questions[1, 0] = "Sa kredi permbajne programet e studimit Bachelor?";
            questions[1, 1] = "170 ECTS kredi";
            questions[1, 2] = "180 ECTS kredi";
            questions[1, 3] = "150 ECTS kredi";
            questions[1, 4] = "120 ECTS kredi";
            //
            questions[2, 0] = "Sa kredi permbajne programet e studimit Master?";
            questions[2, 1] = "*120 ECTS kredi";
            questions[2, 2] = "170 ECTS kredi";
            questions[2, 3] = "190 ECTS kredi";
            questions[2, 4] = "200 ECTS kredi";
            //
            questions[3, 0] = "Cilat jane bizneset qe Kolegji ka bashkepunimi per studime duale?";
            questions[3, 1] = "*Baruti, BPM, FOX Group,Albina Dyla";
            questions[3, 2] = "Elkos,ProCredit,NLB Banka";
            questions[3, 3] = "TEB,Telekomi i Kosoves";
            questions[3, 4] = "Super Viva,KESCO";
            //
            questions[4, 0] = "Permes ciles platforme online zhvillohen studimet";
            questions[4, 1] = "EM-Learning";
            questions[4, 2] = "U-Learning";
            questions[4, 3] = "*E-Learning";
            questions[4, 4] = "SEMS";
            //
            questions[5, 0] = "Me sa universitete te Europes ka marrveshje per studim jashte vendit ";
            questions[5, 1] = "120";
            questions[5, 2] = "*152";
            questions[5, 3] = "130";
            questions[5, 4] = "155";
            //
            questions[6, 0] = "Kolegji Universum ka marreveshje ne  ___ vende te Europes";
            questions[6, 1] = "23";
            questions[6, 2] = "*26";
            questions[6, 3] = "29";
            questions[6, 4] = "31";
            //
            questions[7, 0] = "Sa kampuse ka gjithesej";
            questions[7, 1] = "2";
            questions[7, 2] = "4";
            questions[7, 3] = "6";
            questions[7, 4] = "*3";
            //
            questions[8, 0] = "Certifikatat e leshuara nga ___ jane te pranuara nderkombetarisht";
            questions[8, 1] = "Cambdrige";
            questions[8, 2] = "New Age School";
            questions[8, 3] = "TOEFL";
            questions[8, 4] = "*Anglia Examination";
            //
            questions[9, 0] = "Kur u akreditua per here te pare kolegji";
            questions[9, 1] = "*2009";
            questions[9, 2] = "2008";
            questions[9, 3] = "2011";
            questions[9, 4] = "Asnjera nga keto";
            //
            questions[10, 0] = "Sa studente deri me tani kane perfituar burse te plote nderkombetare";
            questions[10, 1] = "320";
            questions[10, 2] = "315";
            questions[10, 3] = "295";
            questions[10, 4] = "*260";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i,int j)
        {
            return questions[i, j];
        }

    }
}
