// creation de la liste des mots a rechercher
List<string>listMot = new List<string> { "bonjour", "salut", "developpeur", "coucou", "pourquoi", "comment" };

// initialisation du nombre de vie
int nbVie = 10;

// creation d'un index pour chercher un mot aleatoirement dans la liste
Random rand = new Random();
int index = rand.Next(0, listMot.Count());


// creation du stock des lettre trouvée
string[] listLettreTrouver = new string[listMot[index].Count()];

// creatio d'un stockage pour le mauvaise mettre
List<char>listMauvaiseLettre = new List<char>();

//Console.WriteLine($"index du mot a rechercher {index}");
Console.WriteLine($"Mot a rechercher {listMot[index]}");
Console.WriteLine();

// valeur du nombre de lettre trouvées
int nbLetttreTrouve = 0;

// affichage du nombre de caracter que contient le mot a trouver
foreach (char item in listMot[index])
{
    Console.Write(" - ");
}
Console.WriteLine();

while (nbVie > 0 && nbLetttreTrouve < listMot[index].Length)
{
    // Encodage utilisateur
    Console.WriteLine();
    Console.Write("Encodez une lettre : ");
    string? lettre = Console.ReadLine();


    //test si la lettre a deja été joué
    //bool dejaJouer = false;
    //if (nbLetttreTrouve > 0 || listMauvaiseLettre.Count() > 0)
    //{
    //    while (!dejaJouer)
    //    {
    //        if (char.TryParse(lettre, out char le))
    //        {
                
    //            foreach (char item in listMauvaiseLettre)
    //            {
    //                if (item == le)
    //                {
    //                    dejaJouer = true;
    //                }
    //            }

    //        }
    //        foreach (string item in listLettreTrouver)
    //        {
    //            if (item == lettre)
    //            {
    //                dejaJouer = true;
    //            }
    //        }
    //        if (dejaJouer)
    //        {
    //            Console.Write("cette lettre a deja été joué encodez une nouvelle lettre : ");
    //            lettre = Console.ReadLine();
    //            dejaJouer = false;

    //        }
    //    }
    //}



    // test si le valeur encordée est valide
    while (lettre?.Length > 1
            || lettre == "0"
            || lettre == "1"
            || lettre == "2"
            || lettre == "3"
            || lettre == "4"
            || lettre == "5"
            || lettre == "6"
            || lettre == "7"
            || lettre == "8"
            || lettre == "9"
            )
    {
        Console.Write("Encodez une seule lettre et pas un nombre : ");
        lettre = Console.ReadLine();
  
    }



    if (char.TryParse(lettre, out char ch))
    {

        bool trouver = false;
        int i = 0;
        foreach (char l in listMot[index])
        {
            if ((char)ch == l)
            {
                //Console.Write($" {l} ");
                listLettreTrouver[i]=" "+l+" ";
                nbLetttreTrouve++;
                trouver = true;
            }
            else
            {
                if (listLettreTrouver[i] == null)
                    listLettreTrouver[i] = (" - ");
                //Console.Write(" - ");
            }

            i++;
        }
        if (!trouver)
        {
            nbVie--;
            trouver=false;
            listMauvaiseLettre.Add(ch);
        }
        Console.WriteLine($"nombre de vie restante : {nbVie}");


        // afficcher les lettres trouvée
        Console.WriteLine("Lettres trouvées dans le mot");
        foreach (string item in listLettreTrouver)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        // affichage des lettre non trouvées

        if(listMauvaiseLettre.Count > 0)
        {
            Console.WriteLine("Lettres jouées qui ne sont pas dans le mot");
            foreach (char item in listMauvaiseLettre)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
        }
       
    }
    else
    {
        Console.WriteLine("la conversion string vers char n'as pas fonctionné !");
    };

}
if(nbVie > 0)
{
    Console.WriteLine("vous avez gagné");
}
else
{
    Console.WriteLine("vous avez perdu");
}

