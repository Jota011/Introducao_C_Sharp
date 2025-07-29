Se liga filho,

Toda vez que quiser compilar um arquivo, sempre, sempre escreva o comando : csc -nome-do-arquivo.cs  (não sei se tem suporte para outra linguagem)
se nao der bom, procure nas pastas do seu PC, C:\Windows\Microsoft.NET\Framework64\v4.0.30319

Depois jogue no prompet de comando assim:
PATH %path%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319
(Lembrando que você deve fazer o download dos arquivos do .NET ou dotNet, como queira chamar)

Comandos comuns de usar nessas ativades: 
cd ..                       //Sair da pasta atual
cd nomeDaPasta              //Aabrir a pasta desejata
csc nomeDaPasta.cs          //Cria um arquivo executavel
nomeDaPasta                 //Executa o arquivo executavel

-------
dotnet new console -n MeuProjeto        //Cria um projeto de aplicativo usando C# e .NET
dotnet run                              //Roda o Aplicativo

mais detalhes de como fazer o download e configurar no seu PC: https://youtu.be/dVzJ3bx68FA


O melhor comando é o de limpar a tela.
seja em: 
C#:	    -console.clear();
JS:	    -console.clear();
node:	-console.clear();
Mysql:	-system cls;
C:	    -system("cls");
PHP:	-system('cls');
Python:	-os.system('cls')

tudo fica melhor se for bem organizado.