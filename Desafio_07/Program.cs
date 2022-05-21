using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_07.Model;
using Desafio_07.Entidades;


namespace Desafio_07
{
    public class Program
    {
        
        
        enum Menu { Adicional_Cadastro = 1, Sair };
        static void Main(string[] args)
        {

            AlunoEntidade dadoAluno = new AlunoEntidade();
            CursoEntidade dadoCurso = new CursoEntidade();
            StatusEntidade dadoStatus = new StatusEntidade();
            
            bool escolheuSair = false;

            while (!escolheuSair)
            {

                Console.Clear();
                Console.WriteLine("Desafio 7\n");
                Console.WriteLine("1-Adicionar Cadastro\n2-Sair");

                int opInt = int.Parse(Console.ReadLine());

                if (opInt > 0 && opInt < 3)
                {
                    Menu opcoes = (Menu)opInt;
                    switch (opcoes)
                    {
                        case Menu.Adicional_Cadastro:
                            
                            bool escolheuSairCad = false;                
                            while(!escolheuSairCad)
                            {
                                Console.Clear();
                                salvarAluno(dadoAluno);
                                salvarCurso(dadoCurso);
                                salvarStatus(dadoStatus);

                                Console.WriteLine("1-Novo Cadastro\n2-Voltar para o Inicio");
                                int opacao = int.Parse(Console.ReadLine());
                                if(opacao == 2)
                                {
                                    escolheuSairCad = true;
                                }
                            }

                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
            }
        }
//------------------------------------------ Pede nome e idade do aluno e salva no banco
        static void salvarAluno(AlunoEntidade dado)
        {
                AlunoModel model = new AlunoModel();

                string nome = "";
                int idade = 0;

                Console.WriteLine("--------------- CADASTRO DE ALUNO ---------------\n");
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("IDADE: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------");

                try
                {
                    dado.Nome = nome;
                    dado.Idade = idade;

                    model.salvarAlunoModel(dado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO ao SALVAR ALUNO" + ex.Message);
                }
        }

//----------------------------------------------------Pede nome e ano do curso e salava no banco
        static void salvarCurso(CursoEntidade dado)
        {
            CursoModel model = new CursoModel();

            string nomeCurso = "";
            int anoCurso = 0;

            Console.Write("NOME DO CURSO: ");
            nomeCurso = Console.ReadLine();
            Console.Write("ANO : ");
            anoCurso = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");

            try
            {
                dado.Nome = nomeCurso;
                dado.Ano = anoCurso;

                model.salvarCursoModel(dado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO ao SALVAR CURSO " + ex.Message);
            }
        }

//-------------------------------Pede as 4 notas do aluno e mostra media e status (aprovado ou reprovado)
        static void salvarStatus(StatusEntidade dado)
        {
            StatusModel model = new StatusModel();

            
            double nota_1 = 0, nota_2 = 0, nota_3 = 0, nota_4 = 0, media = 0;
            string status = "";

            Console.Write("NOTA 1: ");
            nota_1 = double.Parse(Console.ReadLine());
            Console.Write("NOTA 2: ");
            nota_2 = double.Parse(Console.ReadLine());
            Console.Write("NOTA 3: ");
            nota_3 = double.Parse(Console.ReadLine());
            Console.Write("NOTA 4: ");
            nota_4 = double.Parse(Console.ReadLine());

            media = (nota_1 + nota_2 + nota_3 + nota_4)/4;

            if (media >= 60)
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }

            Console.WriteLine($"MEDIA DAS NOTAS: {media } STATUS DO ALUNO: { status}");

            Console.WriteLine("-----------------------------------------------\n\n\n");

            try
            {
                dado.Nota_1 = nota_1;
                dado.Nota_2 = nota_2;
                dado.Nota_3 = nota_3;
                dado.Nota_4 = nota_4;
                dado.Media = media;
                dado.Status = status;


                model.salvarStatusModel(dado);
                Console.WriteLine("TODOS OS DADOS FORAM SALVOS NO BANCO COM SUCESSO!\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO ao SALVAR STATUS" + ex.Message);
            }
        }

    }
}

