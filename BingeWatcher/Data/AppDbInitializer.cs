using BingeWatcher.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Actors
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Matt LeBlanc",
                            Bio = "Matthew Steven LeBlanc is an American actor, television producer and comedian. He garnered global recognition with his portrayal of Joey Tribbiani in the NBC sitcom Friends and in its spin-off series, Joey.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/f/f4/Matt_LeBlanc%2C_Arqiva_British_Academy_Television_Awards%2C_2013.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Johnny Depp",
                            Bio = "John Christopher Depp II is an American actor, producer, and musician.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTM0ODU5Nzk2OV5BMl5BanBnXkFtZTcwMzI2ODgyNQ@@._V1_.jpgg"
                        },
                        new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "Angelina Jolie DCMG is an American actress and filmmaker.",
                            ProfilePictureURL = "https://i.tmgrup.com.tr/vogue/img/vertical_b/18-05/03/angelina-jolie-505313846-1525340290.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Jim Carrey",
                            Bio = "James Eugene Carrey is a Canadian-American actor, comedian, writer, and producer.",
                            ProfilePictureURL = "http://images5.fanpop.com/image/photos/26700000/Jim-Carrey-jim-carrey-26794567-1000-1516.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Orlando Bloom",
                            Bio = "Orlando Jonathan Blanchard Copeland Bloom is an English actor.",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRyieeiaECJ9u-bY8F0sFsNumNM2qQhcP0oPfWQUvQtILvRNhSs"
                        },
                        new Actor()
                        {
                            FullName = "Liam Neeson",
                            Bio = "William John Neeson OBE is an actor from Northern Ireland.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS20vcfs-ll943ProKEWC0QJ7JrJg8OBCeBiL2AD7rYku9Rwp69"
                        },
                        new Actor()
                        {
                            FullName = "Uma Thurman",
                            Bio = "Uma Karuna Thurman is an American actress, writer, producer and model.",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQ8V_RPCln2qcsQ3kVJp4-ZTogRpO3hWr1qOCcqZ54-wAXhYqOb"
                        },
                        new Actor()
                        {
                            FullName = "Michael J. Anderson",
                            Bio = "Michael J. Anderson is a retired American actor known for his roles as The Man from Another Place in David Lynch's television series Twin Peaks, the prequel film for the series, Twin Peaks: Fire Walk with Me, and as Samson Leonhart on the HBO series Carnivàle.",
                            ProfilePictureURL = "https://townsquare.media/site/442/files/2016/05/twin-peaks-revival-missing-pic.jpg?w=980&q=75"
                        },
                        new Actor()
                        {
                            FullName = "Freddie Highmore",
                            Bio = "Alfred Thomas Highmore is an English actor.",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTYUb6pYrtmRGjRFcanEAXOH5YKnzidL3U-6q4Seor88fc_vIfL"
                        },
                        new Actor()
                        {
                            FullName = "James Spader",
                            Bio = "James Todd Spader is an American actor and producer.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRlOA3Z3m069nmVSzkOdF7GPLvVtDjs0pDLZgs38E0WaZTRpm8L"
                        },
                        new Actor()
                        {
                            FullName = "Bryan Cranston",
                            Bio = "Bryan Lee Cranston is an American actor, director, producer, and screenwriter.",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSa8WhJInX5lOLzFIUyPIup_WWclQTfrOYC-S9AvQFBJVJ-LVE-"
                        },
                        new Actor()
                        {
                            FullName = "Travis Fimmel",
                            Bio = "Travis Fimmel is an Australian actor and former model.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BNzMzNTcwMTkxN15BMl5BanBnXkFtZTgwMTgwMDE1MzI@._V1_UY1200_CR85,0,630,1200_AL_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Viola Davis",
                            Bio = "Viola Davis is an American actress and producer.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ9hOGVDwBVCG7XU1k82yS2jjzHX4UvBDsgxnZL1R6OQHp6b8mN"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "Steven Allan Spielberg is an American film director, producer, and screenwriter.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHVS2ee6usybjD-SvuXSvnWU2E3qf7-5g5YOTbUK71OHqtPVTY"

                        },
                        new Producer()
                        {
                            FullName = "Peter Jackson",
                            Bio = "Sir Peter Robert Jackson ONZ KNZM is a New Zealand film director, screenwriter, and film producer.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRQHnA-V4DqU8xDTpwsADvNWat9IbAgrkKifsp-NUyoHSy5AGw6"
                        },
                        new Producer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "Quentin Jerome Tarantino is an American film director, screenwriter, producer, film critic, and actor.",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxlTrJvdxqSMBYf90USQe0qXEaMhXdy35FJOpUlEZ5PGl4wIBI"
                        },
                        new Producer()
                        {
                            FullName = "David Lynch",
                            Bio = "David Keith Lynch is an American filmmaker, painter, visual artist, musician, and writer.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS3EdZCJ7-noxgOD4QXA8SvxZWRSHFliZanJj2ndCpCREdPnY6U"
                        },
                        new Producer()
                        {
                            FullName = "George Lucas",
                            Bio = "George Walton Lucas Jr. is an American film director, producer, screenwriter, and entrepreneur.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcD3-pANfYEMOBoClEm9bDgFGEqGPbkmDLqhfsLYR7t83uaZ5k"
                        },
                        new Producer()
                        {
                            FullName = "Anthony Cipriano",
                            Bio = "Anthony S. Cipriano (born August 1, 1975) is an American-born writer / producer of TV and motion pictures based in Los Angeles.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BODUwODhhNzAtYWE0NS00ZGRlLTlmNjYtZjk2NDgyODA3ZjE2XkEyXkFqcGdeQXVyMjQwMDg0Ng@@._V1_.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Michael W. Watkins",
                            Bio = "Michael W. Watkins is an American cinematographer, television director and television producer.",
                            ProfilePictureURL = "http://www.purplereels.com/pr/wp-content/uploads/2018/08/Michael-W.-Watkins-photo.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Vince Gilligan",
                            Bio = "George Vincent Gilligan Jr. is an American writer, producer, and director.",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRTAr-YKBwhRfA88BCXYIgtnS_ZX5l7nc5xEK42AFkrr3fftoN9"
                        },
                        new Producer()
                        {
                            FullName = "Morgan O'Sullivan",
                            Bio = "Morgan O'Sullivan is an Irish based Producer and has acted as an Executive Producer or Co-Producer.",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT_f7n5QJ6NI-NdWzSWfFbxqdp5DBWFpdrYRHqd7CLn43GcCYyB"
                        },
                        new Producer()
                        {
                            FullName = "Peter Nowalk",
                            Bio = "Peter Nowalk is an American television writer and producer.",
                            ProfilePictureURL = "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcTbmNdqBsJpajEQunNgkErL0KsoRL4IJHeuPrnzG8Omb3YskU9-tst86ai9jGIU"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Lord of the Rings",
                            Description = "The Lord of the Rings is a film series of three epic fantasy adventure films directed by Peter Jackson, based on the novel written by J. R. R. Tolkien. The films are subtitled The Fellowship of the Ring, The Two Towers, and The Return of the King.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg",
                            ProducerId = 2,
                            Genre = Genre.Fantasy
                        },
                        new Movie()
                        {
                            Name = "Schindler's List",
                            Description = "Oskar Schindler, a German industrialist and member of the Nazi party, tries to save his Jewish employees after witnessing the persecution of Jews in Poland.",
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBoUo0lPtAJiO0RyEb_C44usrfMq4VhNN_L8zk_wtd8QQuZzSh",
                            ProducerId = 1,
                            Genre = Genre.History
                        },
                        new Movie()
                        {
                            Name = "Kill Bill",
                            Description = "Kill Bill: Volume 1 is a 2003 American martial arts film written and directed by Quentin Tarantino.",
                            ImageURL = "https://flxt.tmsimg.com/assets/p32988_p_v10_ae.jpg",
                            ProducerId = 3,
                            Genre = Genre.Action
                        },
                        new Movie()
                        {
                            Name = "Mulholland Drive",
                            Description = "Rita, a dark-haired amnesiac, and Betty, a perky blonde actress, team up to find clues related to Rita's accident and ascertain her true identity.",
                            ImageURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTYrB7ZFkwFPK3lmq_Odq-IbkwuA7KC8YV3KVBWfFsFbmKvTUIb",
                            ProducerId = 4,
                            Genre = Genre.Thriller
                        },
                        new Movie()
                        {
                            Name = "Star Wars",
                            Description = "Star Wars is an American epic space opera multimedia franchise created by George Lucas, which began with the eponymous 1977 film and quickly became a worldwide pop-culture phenomenon.",
                            ImageURL = "https://lumiere-a.akamaihd.net/v1/images/avco_payoff_1-sht_v7_lg_32e68793.jpeg?region=0%2C0%2C1620%2C2400&width=960",
                            ProducerId = 5,
                            Genre = Genre.SciFi
                        },
                        new Movie()
                        {
                            Name = "The Hobbit",
                            Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSx1XrdgIBct_4ZdJyJi1I4RvMXQP3QlpJihbJ7hKBRmWQJdjE-",
                            ProducerId = 2,
                            Genre = Genre.Fantasy
                        }
                    });
                    context.SaveChanges();
                }
                //Series
                if (!context.Series.Any())
                {
                    context.Series.AddRange(new List<Series>()
                    {
                        new Series()
                        {
                            Name = "Bates Motel",
                            Description = "Norman Bates's life spins out of control when his mental health deteriorates. Meanwhile, his mother, Norma, tries to get him the help he needs and protects him from the people around them.",
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLhU8TjQ4YCMKdwhaB3pzwzpdlupuEEtD19lXtmaHLXiOxZjkg",
                            ProducerId = 6,
                            Genre = Genre.Horror
                        },
                        new Series()
                        {
                            Name = "The Blacklist",
                            Description = "A wanted fugitive mysteriously surrenders himself to the FBI and offers to help them capture deadly criminals. His sole condition is that he will work only with the new profiler, Elizabeth Keen.",
                            ImageURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTQvGqZ7rf4jeB5kjBxj2OvZi-YUBpPhlBpEpIWXdcSKuJUucTN",
                            ProducerId = 7,
                            Genre = Genre.Action
                        },
                        new Series()
                        {
                            Name = "Twin Peaks",
                            Description = "An FBI agent, Dale Cooper, is assigned to investigate the murder of a 17-year old schoolgirl, Laura Palmer, in Twin Peaks.",
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtrGpEEbKcNLZ_fypt1KTB6ux51PD52p8xXg5Uw0UNAJ5hCEMI",
                            ProducerId = 4,
                            Genre = Genre.Horror
                        },
                        new Series()
                        {
                            Name = "Breaking Bad",
                            Description = "Walter White, a chemistry teacher, discovers that he has cancer and decides to get into the meth-making business to repay his medical debts. His priorities begin to change when he partners with Jesse.",
                            ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEUOnXKnRL0jeo6y4_Nzt0RggJHYbxI_RjJUgCvmdG28BAwpAx",
                            ProducerId = 8,
                            Genre = Genre.Crime
                        },
                        new Series()
                        {
                            Name = "Vikings",
                            Description = "Ragnar Lothbrok, a legendary Norse hero, is a mere farmer who rises up to become a fearless warrior and commander of the Viking tribes with the support of his equally ferocious family.",
                            ImageURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTQOtj4pUXP9fzyUz5gVYkZt3_1Z1gCNsGEPmT5snx_Xxhp0UNo",
                            ProducerId = 9,
                            Genre = Genre.Drama
                        },
                        new Series()
                        {
                            Name = "How to Get Away with Murder",
                            Description = "Annalise Keating, a criminal defence lawyer and professor, teaches a group of aspiring law students. However, their lives alter when they get entangled in an aberrant murder.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZDQ5ZDRhMWItNjA5Ni00MDhiLTgwN2EtZjFkYzgzNjBhZTIyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1000_.jpg",
                            ProducerId = 10,
                            Genre = Genre.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 2
                        },

                         new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 3
                        },
                         new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Series
                if (!context.Actors_Series.Any())
                {
                    context.Actors_Series.AddRange(new List<Actor_Series>()
                    {
                        new Actor_Series()
                        {
                            ActorId = 9,
                            SeriesId = 1
                        },
                        new Actor_Series()
                        {
                            ActorId = 10,
                            SeriesId = 2
                        },
                         new Actor_Series()
                        {
                            ActorId = 8,
                            SeriesId = 3
                        },
                         new Actor_Series()
                        {
                            ActorId = 11,
                            SeriesId = 4
                        },
                        new Actor_Series()
                        {
                            ActorId = 12,
                            SeriesId = 5
                        },
                        new Actor_Series()
                        {
                            ActorId = 13,
                            SeriesId = 6
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
