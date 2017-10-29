using System;

//BrownDynamite - ….

//Wolowizard - Raj, você está no local ?

//BrownDynamite - … .. --

//Wolowizard - ?

//LHofstadter - Isso é morse ?

//BrownDynamite - … .. --

namespace Desafio02
{
    //NeuroAmy - Aparentemente o cérebro dele conseguiu driblar a mudez seletiva de uma forma que ele agora é capaz de se comunicar conosco. Muito bom Raj !

    //BrownDynamite - --- -... .-. .. --. .- -.. ---

    //BrownDynamite - ---  -. --- - . -... --- --- -.-  - . --  ... . -. .... .-

    //Wolowizard -Isso é muito trabalhoso

    public class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //DrCooperS - .-.. . --- -. .- .-. -..  ..- ... .-  .-  -- . ... -- .-  ... . -. .... .-  .--. .- .-. .-  - ..- -.. ---

            //LHofstadter - Sheldon ! Não fique espalhando minha senha, e não fale em morse, já basta o Raj !

            //DrCooperS - Desculpe mas eu apenas quis me comunicar de igual para igual com nosso amigo. Além disso, todo mundo sabe que você usa a mesma senha para tudo, uma senha bem pouco criativa e segura, todo mundo sabe que usar nomes próprios é pouco aconselhável mesmo sendo um nome alienígena.

            //LHofstadter - Sheldon, chega de dicas, você está revelando muito !

            //DrCooperS - Você usa as “dicas” estampadas na cueca e eu estou revelando muito ?

            //BrownDynamite - .--- .- -.-. --- -. ... . --. ..- ..  --- -... .-. .. --. .- -.. ---

            //PennyActress1985 - Deve ser a mesma do wifi... até anotei num papel

            var desafio = new Desafio02();
            
            Console.WriteLine(string.Format("A senha do notebook do Leonard é: {0}", desafio.Resposta()));

            Console.ReadKey();
        }        
    }
}
