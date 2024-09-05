namespace Lab2
{   
    class Song {
        public String TypeList {get; set;}
        public String Name {get; set;}
        public String Time {get; set;}

        public Song(String typeList,String name,String time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }

    class Ex3 {
        public void run(){
            int num = int.Parse(Console.ReadLine() ?? "0");
            List<Song> list = new List<Song>();

            while (num-- > 0)
            {
                string[] data = (Console.ReadLine() ?? "").Split('_') ;

                Song song = new Song(data[0], data[1], data[2]);

                list.Add(song);
            }

            string TypeList = Console.ReadLine() ?? "";

            if (TypeList.Equals("all"))
            {
                for(int i = 0; i < list.Count; ++i)
                {
                    Console.WriteLine(list[i].Name);
                }
            }
            else
            {
                for(int i = 0; i < list.Count; ++i)
                {
                    if (list[i].TypeList == TypeList)
                    {
                        Console.WriteLine(list[i].Name);
                    }
                }
            }
            Console.ReadKey();
            }

        
    }

}

