using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Yang_Movieapp
{
    public partial class Form1 : Form
    {
        Movie[] movie;
        Cast[] cast;
        Person[] person;
             
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            movie = new Movie[5];

            movie[0] = new Movie("Fast and Furious 6", "PG-13", "2h 10min", "Action, Crime, Thriller", "Justin Lin", "May 24, 2013", "Hobbs has Dominic and Brian reassemble\n their crew to take down a team of mercenaries:\n Dominic unexpectedly gets convoluted also facing\n his presumed deceased girlfriend, Letty.");
            movie[1] = new Movie("Avengers age of Ultron", "PG-13", "2h 21min", "Action, Adventure, Sci-Fi", "Josh Whedon, Stan Lee", "May 1, 2015", "When Tony Stark and Bruce Banner try to\n jump-start a dormant peacekeeping program called\n Ultron, things go horribly wrong and it's up to Ea-\n rth's Mightiest Heroes to stop the villainous Ultron\n from enacting his terrible plans.");
            movie[2] = new Movie("Interstellar", "PG-13", "2h 45min", "Adventure, Drama, Sci-Fi", "Christopher Nolan", "November 7, 2014", "A team of explorers travel through a\n wormhole in space in an attempt to ensure hum-\n anity's survival.");
            movie[3] = new Movie("Rush Hour 3", "PG-13", "1h 31min", "Action, Comedy, Crime", "Brett Ratner", "August 10, 2007", "After an attempted assassination on\n Ambassador Han, Lee and Carter head to\n Paris to protect a French woman with knowledge\n of the Triads' secret leaders.");
            movie[4] = new Movie("Transformers: Dark of the Moon", "PG-13","2h 31min", "Action, Adventure, Sci-Fi", "Michael Bay", "June 29, 2011", "The Autobots learn of a Cybertronian\n spacecraft hidden on the moon, and race against\n the Decepticons to reach it and to learn its secrets.");

            cast = new Cast[15];
            cast[0] = new Cast("Vin Disel", "", "", "", "");
            cast[1] = new Cast("Paul Walker", "", "", "", "");
            cast[2] = new Cast("Dwyane Johnson", "", "", "", "");

            cast[3] = new Cast("Robert Downey Jr.", "", "", "", "");
            cast[4] = new Cast("Chris Evans", "", "", "", "");
            cast[5] = new Cast("Chris Hemsworth", "", "", "", "");

            cast[6] = new Cast("Matthew McConaughey", "", "", "", "");
            cast[7] = new Cast("Ellen Burstyn", "", "", "", "");
            cast[8] = new Cast("Mackenzie Foy", "", "", "", "");

            cast[9] = new Cast("Chris Tucker", "", "", "", "");
            cast[10] = new Cast("Jackie Chan", "", "", "", "");
            cast[11] = new Cast("Max von Sydow", "", "", "", "");

            cast[12] = new Cast("Shia LaBeouf", "", "", "", "");
            cast[13] = new Cast("Josh Duhamel", "", "", "", "");
            cast[14] = new Cast("Tyrese Gibson", "", "", "", "");



            person = new Person[15];
            person[0] = new Person("Vin", "Disel", " July 18, 1967 in Alameda County, California, USA", "Vin Diesel was born Mark Sinclair in Alameda County, California, along with his fraternal twin brother, Paul Vincent. He was raised by his astrologer/psychologist mother, Delora Sherleen (Sinclair), and adoptive father, Irving H. Vincent, an acting instructor and theater manager, in an artist's housing project in New York City's Greenwich Village.");
            person[1] = new Person("Paul", "Walker", "September 12, 1973 in Glendale, California, USA", "aul William Walker IV was born in Glendale, California. He grew up together with his brothers, Caleb and Cody, and sisters, Ashlie and Amie. Their parents, Paul William Walker III, a sewer contractor, and Cheryl (Crabtree) Walker, a model, separated around September 2004. His grandfather, William Walker, was a Pearl Harbor survivor and a Navy middleweight boxing champion, while his maternal grandfather commanded a tank battalion in Italy under General Patton during World War II.");
            person[2] = new Person("Dwyane", "Johnson", "May 2, 1972 in Hayward, California, USA", "Dwayne Douglas Johnson, also known as The Rock, was born on May 2, 1972 in Hayward, California, to Ata Johnson (born Feagaimaleata Fitisemanu Maivia) and Canadian-born professional wrestler Rocky Johnson (born Wayde Douglas Bowles). His father is black (of Black Nova Scotian descent), and his mother is of Samoan background (her own father was Peter Fanene Maivia, also a professional wrestler).");

            person[3] = new Person("Robert", " Downey Jr.", "April 4, 1965 in Manhattan, New York City, New York, USA", "Downey was born April 4, 1965 in Manhattan, New York, the son of writer, director and filmographer Robert Downey Sr. and actress Elsie Downey (née Elsie Ann Ford). Robert's father is of half Lithuanian Jewish, one quarter Hungarian Jewish, and one quarter Irish, descent, while Robert's mother was of English, Scottish, German, and Swiss-German ancestry.");
            person[4] = new Person("Chris", "Evans", "June 13, 1981 in Boston, Massachusetts, USA", "He was born in Boston, Massachusetts, the son of Lisa (Capuano), who worked at the Concord Youth Theater, and G. Robert Evans III, a dentist. His uncle is congressman Mike Capuano. Chris's father is of half German and half Welsh/English/Scottish ancestry, while Chris's mother is of half Italian and half Irish descent. He has an older sister, Carly Evans, and two younger siblings, a brother named Scott Evans, and a sister named Shana Evans");
            person[5] = new Person("Chris", "Hemsworth", "August 11, 1983 in Melbourne, Victoria, Australia", "Chris Hemsworth was born in Melbourne, Australia, to Leonie (van Os), a teacher of English, and Craig Hemsworth, a social-services counselor. His brothers are actors Liam Hemsworth and Luke Hemsworth. He is of Dutch (from his immigrant maternal grandfather), Irish, English, Scottish, and German ancestry.");

            person[6] = new Person("Matthew", "McConaughey", "November 4, 1969 in Uvalde, Texas, USA", "American actor and producer Matthew David McConaughey was born in Uvalde, Texas. His mother, Mary Kathleen (McCabe), is a substitute school teacher originally from New Jersey. His father, James Donald McConaughey, was a Mississippi-born gas station owner who ran an oil pipe supply business. He is of Scottish, Irish, English, German, and Swedish descent.");
            person[7] = new Person("Ellen", "Burstyn", "December 7, 1932 in Detroit, Michigan, USA", "Ellen Burstyn was born in Detroit, Michigan, to Correine Marie (Hamel) and John Austin Gillooly. She is of mostly Irish, German, and French-Canadian descent. Ellen worked a number of jobs before she became an actress. At 14, she was a short-order cook at a lunch counter. After graduating from Detroit's Cass Technical High School, she went to Texas to model and then to New York as a showgirl on The Jackie Gleason Show (1952). ");
            person[8] = new Person("Mackenzie", "Foy", "November 10, 2000 in USA", "Mackenzie Christine Foy was born 10 November, 2000. She began her career as a child model in 2004, working for Garnet Hill, Polo Ralph Lauren, and Guess Kids. She has also modeled in print ads for companies such as Rubbermaid, Jones Apparel Group,The Walt Disney Company, Mattel, Target Corporation, Talbots, Guess and Gap.");

            person[9] = new Person("Chris", "Tucker", "August 31, 1972 in Atlanta, Georgia, USA", "Tucker was born in Atlanta, Georgia, to Mary Louise (Bryant) and Norris Tucker, who owned a janitorial service. After graduating from high school, Tucker made a change to move to Hollywood from Georgia to pursue a career in show business. He found himself a frequent guest on the Def Comedy Jam (1992).");
            person[10] = new Person("Jackie", "Chan", "April 7, 1954 in Victoria Peak, Hong Kong", "Jackie was born Kong-sang Chan on Hong Kong's famous Victoria Peak on April 7, 1954, to Charles and Lee-Lee Chan, and the family emigrated to Canberra, Australia, in early 1960. The young Jackie was less than successful scholastically, so his father sent him back to Hong Kong to attend the rigorous China Drama Academy, one of the Peking Opera schools.");
            person[11] = new Person("Max", "von Sydow", "April 10, 1929 in Lund, Skåne län, Sweden", "Max von Sydow was born Carl Adolf von Sydow on April 10, 1929 in Lund, Skåne, Sweden, to a middle-class family. He is the son of Baroness Maria Margareta (Rappe), a teacher, and Carl Wilhelm von Sydow, an ethnologist and folklore professor. His surname traces back to his father's partial German ancestry.");

            person[12] = new Person("Shia", "LaBeouf", "June 11, 1986 in Los Angeles, California, USA", "Shia Saide LaBeouf was born in Los Angeles, California, to Shayna (Saide) and Jeffrey Craig LaBeouf, and is an only child. His mother is from an Ashkenazi Jewish family, while his father has Cajun (French) ancestry. His parents are divorced. He started his career by doing stand-up comedy around places in his neighborhood, such as coffee clubs.");
            person[13] = new Person("Josh", "Duhamel", "November 14, 1972 in Minot, North Dakota, USA", "Joshua David Duhamel was born in Minot, North Dakota. His mother, Bonny L., is a retired high school teacher and the current Executive Director of Minot's Downtown Business & Profession Association, and his father, Larry Duhamel, is an advertisement salesman. Josh has three younger sisters: Ashlee, McKenzee and Kassidy.");
            person[14] = new Person("Tyrese", "Gibson", "December 30, 1978 in Watts, Los Angeles, California, USA", "Tyrese Darnell Gibson was born December 30, 1978 in Watts, Los Angeles, California, where he was raised. He is an R&B singer, songwriter, actor, author, television producer and model. He is well known for his actor role as Roman Pearce in the The Fast and Furious movie franchise.");



        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label9.Text = movie[0].ToString();
            label10.Text = cast[0].ToString();
            label11.Text = cast[1].ToString();
            label13.Text = cast[2].ToString();
            label12.Text = "";
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label9.Text = movie[1].ToString();
            label10.Text = cast[3].ToString();
            label11.Text = cast[4].ToString();
            label13.Text = cast[5].ToString();
            label12.Text = "";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label9.Text = movie[2].ToString();
            label10.Text = cast[6].ToString();
            label11.Text = cast[7].ToString();
            label13.Text = cast[8].ToString();
            label12.Text = "";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label9.Text = movie[3].ToString();
            label10.Text = cast[9].ToString();
            label11.Text = cast[10].ToString();
            label13.Text = cast[11].ToString();
            label12.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label9.Text = movie[4].ToString();
            label10.Text = cast[12].ToString();
            label11.Text = cast[13].ToString();
            label13.Text = cast[14].ToString();
            label12.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

           label12.Text = person[0].ToString();
            switch (label10.Text)
            {
                case "Robert Downey Jr.":
                    label12.Text = person[3].ToString();
                    break;
                case "Matthew McConaughey":
                    label12.Text = person[6].ToString();
                    break;
                case "Chris Tucker":
                    label12.Text = person[9].ToString();
                    break;
                case "Shia LaBeouf":
                    label12.Text = person[12].ToString();
                    break;

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label12.Text = person[1].ToString();
            switch (label11.Text)
            {
                case "Chris Evans":
                    label12.Text = person[4].ToString();
                    break;
                case "Ellen Burstyn":
                    label12.Text = person[7].ToString();
                    break;
                case "Jackie Chan":
                    label12.Text = person[10].ToString();
                    break;
                case "Josh Duhamel":
                    label12.Text = person[13].ToString();
                    break;

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label12.Text = person[2].ToString();
            switch (label13.Text)
            {
                case "Chris Hemsworth":
                    label12.Text = person[5].ToString();
                    break;
                case "Mackenzie Foy":
                    label12.Text = person[8].ToString();
                    break;
                case "Max von Sydow":
                    label12.Text = person[11].ToString();
                    break;
                case "Tyrese Gibson":
                    label12.Text = person[14].ToString();
                    break;

            }
        }

        
    }
}
