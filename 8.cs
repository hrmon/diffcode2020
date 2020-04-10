using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User {
    public string name;
    public string city;
    public Int32 age;
    public ArrayList albums;

    public User(string n,  string a, string c) {
        name = n;
        city = c;
        age = Convert.ToInt32(a);
        albums = new ArrayList();
    }

}

public class Album {
    public string name, singer, genre;
    public Int32 tracks;
    
    public Album(string n, string s, string g, string t) {
        name = n;
        singer = s;
        genre = g;
        tracks = Convert.ToInt32(t);
    }
}

public class App
{
    public static User[] users = new User[200];
    public static Album[] albums = new Album[200];
    public static Int32 n,m,q;

    public static Int32 CountBySinger(User user, string singer) {
        Int32 c = 0;
        foreach (string albumName in user.albums) {
            for (Int32 i=0; i<m; i++) {
                if (albums[i].name == albumName && albums[i].singer == singer) {
                    c += albums[i].tracks;
                }
            }
        }
        return c;
    }

    public static Int32 CountByGenre(User user, string genre) {
        Int32 c = 0;
        foreach (string albumName in user.albums) {
            for (Int32 i=0; i<m; i++) {
                if (albums[i].name == albumName && albums[i].genre == genre) {
                    c += albums[i].tracks;
                }
            }
        }
        return c;
    }

    public static void Main(string[] args)
    {
        n = Convert.ToInt32(Console.ReadLine());
        Int32 it = 0;
        string li;
        while (true) {
            li = Console.ReadLine();
            if (li[0] == '-') {
                users[it++] = new User(
                    li.Substring(8),
                    Console.ReadLine().Substring(7),
                    Console.ReadLine().Substring(8)
                );
                Console.ReadLine();
            } else if (li[0] != ' ') {
                break;
            } else {
                users[it-1].albums.Add(li.Substring(6));
            }
        }
        m = Convert.ToInt32(li);
        for(Int32 i=0; i<m; i++) {
            albums[i] = new Album(
                Console.ReadLine().Substring(8),
                Console.ReadLine().Substring(10),
                Console.ReadLine().Substring(9),
                Console.ReadLine().Substring(10)
            );
        }
        // Queries
        q = Convert.ToInt32(Console.ReadLine());
        for(Int32 i=0; i<q; i++) {
            string[] tk = Console.ReadLine().Split(' ');
            Boolean fl = false;
            Int32 count = 0, age;
            string city;
            switch(tk[0]) {
                case "1":
                    for (Int32 j=0; j<n; j++) {
                        if (tk[1] == users[j].name) {
                            Console.WriteLine(CountBySinger(users[j], tk[2]));
                            fl = true;
                            break;
                        }
                    }
                    if (!fl) Console.WriteLine(0);
                    break;
                case "2":
                    for (Int32 j=0; j<n; j++) {
                        if (tk[1] == users[j].name) {
                            Console.WriteLine(CountByGenre(users[j], tk[2]));
                            fl = true;
                            break;
                        }
                    }
                    if (!fl) Console.WriteLine(0);
                    break;
                case "3":
                    age = Convert.ToInt32(tk[1]);
                    for (Int32 j=0; j<n; j++) {
                        if (age == users[j].age) {
                            count += CountBySinger(users[j], tk[2]);
                        }
                    }
                    Console.WriteLine(count);
                    break;
                case "4":
                    age = Convert.ToInt32(tk[1]);
                    for (Int32 j=0; j<n; j++) {
                        if (age == users[j].age) {
                            count += CountByGenre(users[j], tk[2]);
                        }
                    }
                    Console.WriteLine(count);
                    break;
                case "5":
                    city = tk[1];
                    for (Int32 j=0; j<n; j++) {
                        if (city == users[j].city) {
                            count += CountBySinger(users[j], tk[2]);
                        }
                    }
                    Console.WriteLine(count);
                    break;
                case "6":
                    city = tk[1];
                    for (Int32 j=0; j<n; j++) {
                        if (city == users[j].city) {
                            count += CountByGenre(users[j], tk[2]);
                        }
                    }
                    Console.WriteLine(count);
                    break;
            }
        }
    }
}