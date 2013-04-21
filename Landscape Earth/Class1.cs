using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Landscape_Earth
{
    class Class1
    {

        public String[,] Universe()
        {
            string[,] Meteor = new string[4, 3];
            string[] Meteorites = new string[4];
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0: Meteorites = getNames(@"Assets/XML/Galaxies.xml", "A");
                        break;
                    case 1: Meteorites = getNames(@"Assets/XML/Galaxies.xml", "B");
                        break;
                    case 2: Meteorites = getNames(@"Assets/XML/Galaxies.xml", "C");
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 4; j++)
                {
                    Meteor[j, i] = Meteorites[j];
                }

            }

            return Meteor;
        }

        public String[,] AttributeName4Universe()
        {
            string[,] AttributePlanet = new string[1, 3];
            string[] PlanetName = new string[1];
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/AttributeNameUniverse.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/AttributeNameUniverse.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/AttributeNameUniverse.xml", "C");
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 1; j++)
                {
                    AttributePlanet[j, i] = PlanetName[j];
                }

            }

            return AttributePlanet;
        }

        public String[,] TriviaThing()
        {
            string[,] Meteor = new string[8,4];
            string[] Meteorites = new string[8];
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0: Meteorites = getNames(@"Assets/XML/Landforms.xml", "A");
                        break;
                    case 1: Meteorites = getNames(@"Assets/XML/Landforms.xml", "B");
                        break;
                    case 2: Meteorites = getNames(@"Assets/XML/Landforms.xml", "C");
                        break;
                    case 3: Meteorites = getNames(@"Assets/XML/Landforms.xml", "D");
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 8; j++)
                {
                    Meteor[j, i] = Meteorites[j];
                }

            }

            return Meteor;
        }

        public String[,] AttributeName4Trivia()
        {
            string[,] AttributePlanet = new string[1, 4];
            string[] PlanetName = new string[1];
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/AttributeNamesTrivia.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/AttributeNamesTrivia.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/AttributeNamesTrivia.xml", "C");
                        break;
                    case 3: PlanetName = getNames(@"Assets/XML/AttributeNamesTrivia.xml", "D");
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 1; j++)
                {
                    AttributePlanet[j, i] = PlanetName[j];
                }

            }

            return AttributePlanet;
        }


        public String[,] Meteor()
        {
            string[,] Meteor = new string[4, 3];
            string[] Meteorites = new string[4];
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0: Meteorites = getNames(@"Assets/XML/Comets.xml", "A");
                        break;
                    case 1: Meteorites = getNames(@"Assets/XML/Comets.xml", "B");
                        break;
                    case 2: Meteorites = getNames(@"Assets/XML/Comets.xml", "C");
                        break; 
                    default:
                        break;
                }
                for (int j = 0; j < 4; j++)
                {
                    Meteor[j, i] = Meteorites[j];
                }
                 
            }

            return Meteor;
        }

        public String[,] AttributeName4Meteor()
        {
            string[,] AttributePlanet = new string[1, 3];
            string[] PlanetName = new string[1];
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/AttributeNameMeteors.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/AttributeNameMeteors.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/AttributeNameMeteors.xml", "C");
                        break; 
                    default:
                        break;
                }
                for (int j = 0; j < 1; j++)
                {
                    AttributePlanet[j, i] = PlanetName[j];
                }

            }

            return AttributePlanet;  
        }


        public String[,] DwarfSystemPlanets()
        {
            string[,] DwarfPlanets = new string[5, 10];
            string[] PlanetName = new string[5];
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "C");
                        break;
                    case 3: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "D");
                        break;
                    case 4: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "E");
                        break;
                    case 5: PlanetName = getNames(@"XAssets/ML/Comparing Earth Landscapes Dwarf.xml", "F");
                        break;
                    case 6: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "G");
                        break;
                    case 7: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "H");
                        break;
                    case 8: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "I");
                        break;
                    case 9: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Dwarf.xml", "J");
                        break; 
                    default:
                        break;
                }
                for (int j = 0; j < 5; j++)
                {
                    DwarfPlanets[j, i] = PlanetName[j];
                }


            }

            return DwarfPlanets; 
        }

        public String[,] AttributeName4Planets()
        {
            string[,] AttributePlanet = new string[1, 21];
            string[] PlanetName = new string[1];
            for (int i = 0; i < 21; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "C");
                        break;
                    case 3: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "D");
                        break;
                    case 4: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "E");
                        break;
                    case 5: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "F");
                        break;
                    case 6: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "G");
                        break;
                    case 7: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "H");
                        break;
                    case 8: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "I");
                        break;
                    case 9: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "J");
                        break;
                    case 10: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "K");
                        break;
                    case 11: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "L");
                        break;
                    case 12: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "M");
                        break;
                    case 13: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "N");
                        break;
                    case 14: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "O");
                        break;
                    case 15: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "P");
                        break;
                    case 16: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "Q");
                        break;
                    case 17: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "R");
                        break;
                    case 18: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "S");
                        break;
                    case 19: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "T");
                        break;
                    case 20: PlanetName = getNames(@"Assets/XML/AttributeNames.xml", "U");
                        break; 
                    default:
                        break;
                }
                for (int j = 0; j < 1; j++)
                {
                    AttributePlanet[j, i] = PlanetName[j];
                }

            }

            return AttributePlanet; 


        }

         
        public String[,] SolarSystemPlanets()
        {

           string[,] SolarSystem = new string[8, 21];
            string[] PlanetName = new string[8];
            for (int i = 0; i < 21; i++)
            {
                switch (i)
                {
                    case 0: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "A");
                        break;
                    case 1: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "B");
                        break;
                    case 2: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "C");
                        break;
                    case 3: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "D");
                        break;
                    case 4: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "E");
                        break;
                    case 5: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "F");
                        break;
                    case 6: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "G");
                        break;
                    case 7: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "H");
                        break;
                    case 8: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "I");
                        break;
                    case 9: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "J");
                        break;
                    case 10: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "K");
                        break;
                    case 11: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "L");
                        break;
                    case 12: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "M");
                        break;
                    case 13: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "N");
                        break;
                    case 14: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "O");
                        break;
                    case 15: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "P");
                        break;
                    case 16: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "Q");
                        break;
                    case 17: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "R");
                        break;
                    case 18: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "S");
                        break;
                    case 19: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "T");
                        break;
                    case 20: PlanetName = getNames(@"Assets/XML/Comparing Earth Landscapes Regular.xml", "U");
                        break; 
                    default:
                        break;
                }
                for (int j = 0; j < 8; j++)
                {
                    SolarSystem[j,i] = PlanetName[j];
                }


            }

            return SolarSystem;
        }





        private string[] getNames(string fileName, string attribute)
        {
            XmlReader xmlReader = XmlReader.Create(fileName);
            List<string> names = new List<string>();

            while (xmlReader.Read())
            {
                //keep reading until we see your element
                if (xmlReader.Name.Equals("Record") && (xmlReader.NodeType == XmlNodeType.Element))
                {
                    // get attribute from the Xml element here
                    string name = xmlReader.GetAttribute(attribute);
                    // --> now **add to collection** - or whatever
                    names.Add(name);
                }
            }

            return names.ToArray();
        }






    }
}
