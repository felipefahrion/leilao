using LeilaoDoMeuCoracao.PL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeilaoDoMeuCoracao
{
    class Program
    {
        static void Main(string[] args)
        {
            LeilaoContext context = new LeilaoContext();

            List<User> usuarios = new List<User> {
                new User
                {
                    Nome = "Thais",
                    Email = "thais.fernandes@edu.pucrs.br",
                    Cpf = "00100100122",
                    Cnpj = "",
                    Telefone = ""
                },
                new User
                {
                    Nome = "Marina",
                    Email = "marina.moreira@edu.pucrs.br",
                    Cpf = "00100100122",
                    Cnpj = "",
                    Telefone = ""
                },
                new User
                {
                    Nome = "Arthur",
                    Email = "arthur.maciel@edu.pucrs.br",
                    Cpf = "00100100122",
                    Cnpj = "",
                    Telefone = ""
                },
                new User
                {
                    Nome = "Felipe",
                    Email = "felipe.fahrion@edu.pucrs.br",
                    Cpf = "00100100122",
                    Cnpj = "",
                    Telefone = ""
                },
                new User
                {
                    Nome = "Bruno",
                    Email = "bruno.abbad@edu.pucrs.br",
                    Cpf = "00100100122",
                    Cnpj = "",
                    Telefone = ""
                }
            };

            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria {Nome = "Informatica",  Descricao = "Produtos Informatica"},
                new Categoria {Nome = "Estetica",  Descricao = "Produtos de Beleza"},
                new Categoria {Nome = "Academia", Descricao = "Produtos para Academia"},
                new Categoria {Nome = "Moda Masculina", Descricao = "Produtos para Moda Masculina"},
                new Categoria {Nome = "Moda Feminina", Descricao = "Produtos para Moda Feminina"},
                new Categoria {Nome = "Casa", Descricao = "Produtos para Casa"},
                new Categoria {Nome = "Automóveis", Descricao = "Produtos para Automóvel"},
                new Categoria {Nome = "Games", Descricao = "Produtos para Consoles"},
                new Categoria {Nome = "Acessorios", Descricao = "Acessórios para o dia a dia"},
                new Categoria {Nome = "Maquiagem", Descricao = "Produtos de Beleza"},
                new Categoria {Nome = "Livros", Descricao = "Produtos para leitura"},
                new Categoria {Nome = "Filmes e Séries", Descricao = "Entreterimento"},
                new Categoria {Nome = "Infantil", Descricao = "Produtos para crianças"},
            };

            List<Item> itens = new List<Item>
            {
                new Item {
                    Nome = "Carrinho de bebê",
                    DescricaoBreve = "Carrinho de passeio para bebê da marca Galzerano",
                    DescricaoCompleta = "Carrinho de passeio para bebê da marca Galzerano",
                    Categoria =  categorias.Single( g => g.Nome == "Infantil"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Banquetas",
                    DescricaoBreve = "Banquetas para uso interno da casa. Idela em lugares com lobbys compartilhados",
                    DescricaoCompleta = "Banquetas para uso interno da casa. Idela em lugares com lobbys compartilhados",
                    Categoria =  categorias.Single( g => g.Nome == "Casa"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Rélógio",
                    DescricaoBreve = "Relógio da marca Invicta, apenas 2 meses de uso",
                    DescricaoCompleta = "Relógio da marca Invicta, apenas 2 meses de uso",
                    Categoria =  categorias.Single( g => g.Nome == "Acessorios"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Mouse",
                    DescricaoBreve = "Mouse wireless de Computador com entrada USB 2.0",
                    DescricaoCompleta = "Mouse wireless de Computador com entrada USB 2.0",
                    Categoria =  categorias.Single( g => g.Nome == "Infantil"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Livro Steve Jobs",
                    DescricaoBreve = "A Cabeça de Steve Jobs é um livro de Marcio Edson Tavares, lançado em 2010, que retrata aspectos da vida e personalidade de Steve Jobs. Conforme sinopse da Livraria Cultura, o livro é, ao mesmo tempo, uma biografia e um guia sobre liderança",
                    DescricaoCompleta = "A Cabeça de Steve Jobs é um livro de Marcio Edson Tavares, lançado em 2010, que retrata aspectos da vida e personalidade de Steve Jobs. Conforme sinopse da Livraria Cultura, o livro é, ao mesmo tempo, uma biografia e um guia sobre liderança",
                    Categoria =  categorias.Single( g => g.Nome == "Informatica"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Creme de massagem drenante",
                    DescricaoBreve = "Creme de massagem desenvolvido para auxiliar na ativação do sistema linfático, este creme com óleo de pimenta negra, termogênico de origem natural, é indicado para massagens modeladoras",
                    DescricaoCompleta = "Creme de massagem desenvolvido para auxiliar na ativação do sistema linfático, este creme com óleo de pimenta negra, termogênico de origem natural, é indicado para massagens modeladoras",
                    Categoria =  categorias.Single( g => g.Nome == "Estetica"),
                    Imagem = ""
                },
                new Item {
                    Nome = "Halteres 20 kg",
                    DescricaoBreve = "2 (dois) Halteres, bem cuidados da marca Phonex. Com um ano de garantia",
                    DescricaoCompleta = "2 (dois) Halteres, bem cuidados da marca Phonex. Com um ano de garantia",
                    Categoria =  categorias.Single( g => g.Nome == "Academia"),
                    Imagem = ""
                }
            };

            List<Lance> lances = new List<Lance> {
                new Lance
                {
                    LanceId = 11,
                    DataHoraLance = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    Valor = 300,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Bruno")
                },
                new Lance
                {
                    LanceId = 12,
                    DataHoraLance = new DateTime(2020, 7, 30, 12, 0, 0, 0),
                    Valor = 400,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Felipe")
                },
                new Lance
                {
                    LanceId = 13,
                    DataHoraLance = new DateTime(2020, 2, 22, 12, 0, 0, 0),
                    Valor = 500,
                    Aceito = true,
                    User = usuarios.Single(u => u.Nome == "Marina")
                }
            };

            List<Lance> lances2 = new List<Lance> {
                new Lance
                {
                    LanceId = 21,
                    DataHoraLance = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    Valor = 300,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Bruno")
                },
                new Lance
                {
                    LanceId = 22,
                    DataHoraLance = new DateTime(2020, 7, 30, 12, 0, 0, 0),
                    Valor = 400,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Felipe")
                },
                new Lance
                {
                    LanceId = 23,
                    DataHoraLance = new DateTime(2020, 2, 22, 12, 0, 0, 0),
                    Valor = 500,
                    Aceito = true,
                    User = usuarios.Single(u => u.Nome == "Marina")
                }
            };

            List<Lance> lances3 = new List<Lance> {
                new Lance
                {
                    Valor = 300,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Bruno")
                },
                new Lance
                {
                    DataHoraLance = new DateTime(2020, 7, 30, 12, 0, 0, 0),
                    Valor = 400,
                    Aceito = false,
                    User = usuarios.Single(u => u.Nome == "Felipe")
                },
                new Lance
                {
                    DataHoraLance = new DateTime(2020, 2, 22, 12, 0, 0, 0),
                    Valor = 500,
                    Aceito = true,
                    User = usuarios.Single(u => u.Nome == "Marina")
                }
            };

            List<Leilao> leiloes = new List<Leilao> {
                new Leilao
                {
                    UserCriador = usuarios.Single(u => u.Nome == "Thais"),
                    DataInicio = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    DataMaxLances = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    Valor = 300.50,
                    StatusLeilaoEnum = PL.Enum.StatusLeilaoEnum.ABERTO,
                    TipoLeilaoEnum = PL.Enum.TipoLeilaoEnum.OFERTA,
                    Itens = new List<Item>(),
                    Lances = lances
                },
                new Leilao
                {
                    UserCriador = usuarios.Single(u => u.Nome == "Thais"),
                    DataInicio = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    DataMaxLances = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    Valor = 100.0,
                    StatusLeilaoEnum = PL.Enum.StatusLeilaoEnum.ABERTO,
                    TipoLeilaoEnum = PL.Enum.TipoLeilaoEnum.DEMANDA,
                    Itens = new List<Item>(),
                    Lances = lances2
                },
                new Leilao
                {
                    UserCriador = usuarios.Single(u => u.Nome == "Thais"),
                    DataInicio = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    DataMaxLances = new DateTime(2020, 4, 16, 12, 0, 0, 0),
                    Valor = 800.90,
                    StatusLeilaoEnum = PL.Enum.StatusLeilaoEnum.FECHADO,
                    TipoLeilaoEnum = PL.Enum.TipoLeilaoEnum.DEMANDA,
                    Itens = itens,
                    Lances = lances3
                }
            };

            using (var db = new LeilaoContext())
            {
                #region UsersSeeding
                if (db.Users.Count() == 0)
                {
                    UsersSeed(db, usuarios);
                }
                #endregion

                #region ItensComCategoriasSeeding
                if (db.Itens.Count() == 0)
                {
                    ItensComCategoriasSeed(db, categorias, itens);
                }
                #endregion

                #region LeiloesSeeding
                if (db.Leiloes.Count() == 0)
                {
                    LeiloesSeed(db, leiloes);
                }
                #endregion

                #region LancesSeeding
                if (db.Lances.Count() == 0)
                {
                    LancesSeed(db, lances);
                    LancesSeed(db, lances2);
                    LancesSeed(db, lances3);
                }
                #endregion
            }

            #region Consulta Categorias
            Console.WriteLine();
            Console.WriteLine("Categorias");
            Console.WriteLine();

            var categoriasConsulta = from c in context.Categorias
                             select c.Nome;

            foreach (String categoriasNome in categoriasConsulta)
            {
                Console.WriteLine(categoriasNome);
            }
            #endregion

            #region Consulta Itens
            Console.WriteLine();
            Console.WriteLine("Itens");
            Console.WriteLine();

            var itensConsulta = from c in context.Itens
                        select c.Nome;

            foreach (String itemNome in itensConsulta)
            {
                Console.WriteLine(itemNome);
            }
            #endregion

            #region Consulta Users
            Console.WriteLine();
            Console.WriteLine("Users");
            Console.WriteLine();

            var users = from c in context.Users
                        select c.Nome;

            foreach (String userNome in users)
            {
                Console.WriteLine(userNome);
            }
            #endregion
        }

        private static void ItensComCategoriasSeed(LeilaoContext db, List<Categoria> categorias, List<Item> itens)
        {
            
            db.Categorias.AddRange(categorias);
            db.SaveChanges();

            db.Itens.AddRange(itens);
            db.SaveChanges();
        }

        private static void UsersSeed(LeilaoContext db, List<User> usuarios)
        {
            db.Users.AddRange(usuarios);
            db.SaveChanges();
        }

        public static void LeiloesSeed(LeilaoContext db, List<Leilao> leiloes)
        {
            db.Leiloes.AddRange(leiloes);
            db.SaveChanges();
        }
                
        public static void LancesSeed(LeilaoContext db, List<Lance> lances)
        {
            db.Lances.AddRange(lances);
            db.SaveChanges();
        }
    }
}
