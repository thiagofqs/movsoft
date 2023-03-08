namespace MovSoft.Classes
{
    public class Parametros
    {
        //Dados Usuário Logado
        public static int? idUser { get; set; }
        public static string? nomeUser { get; set; }
        public static string? senhaUser { get; set; }
        public static string? cargoUser { get; set; }
        public static char? adminUser { get; set; }
        public static int? idCargoUser { get; set; }
        public static char? permissaoUser { get; set; }

        //Dados dos Colaboradores Editar/Cadastro
        public static int? idColab { get; set; }
        public static string? nomeColab { get; set; }
        public static string? sobrenomeColab { get; set; }
        public static int? idSexoColab { get; set; }
        public static string? cpfColab { get; set; }
        public static string? nascimentoColab { get; set; }
        public static string? nascimentoInputColab { get; set; }
        public static string? emailColab { get; set; }
        public static int? idCelularColab { get; set; }
        public static string? dddColab { get; set; }
        public static string? celularColab { get; set; }
        public static string ColaboradorAtivo { get; set; }

        //Dados Clientes Editar/Cadastro
        public static int? idCliente { get; set; }
        public static string? nomeCliente { get; set; }
        public static string? sobrenomeCliente { get; set; }
        public static int? idSexoCliente { get; set; }
        public static string? cpfCliente { get; set; }
        public static string? nascimentoCliente { get; set; }
        public static string? nascimentoInputCliente { get; set; }
        public static string? emailCliente { get; set; }
        public static int? idCelularCliente { get; set; }
        public static string? dddCliente { get; set; }
        public static string? celularCliente { get; set; }
        public static string ClienteAtivo { get; set; }

        //Dados Fornecedores Editar/Cadastro
        public static int? idFornecedor { get; set; }
        public static string? nomeFantasia { get; set; }
        public static string? razaoSocial { get; set; }
        public static string? cnpj { get; set; }

        public static string FornecedorAtivo { get; set; }

        //Dados Endereços Editar/Cadastro
        public static int? idEndereco { get; set; }
        public static string? cep { get; set; }
        public static string? logradouro { get; set; }
        public static string? numero { get; set; }
        public static string? complemento { get; set; }
        public static string? cidade { get; set; }
        public static string? bairro { get; set; }
        public static string? uf { get; set; }

        //Dados Usuário Editar/Cadastro

        public static int? idUserEdit { get; set; }
        public static string? nomeUserEdit { get; set; }
        public static string? cargoUserEdit { get; set; }
        public static string? colaboradorUserEdit { get; set; }
        public static string UserAtivo { get; set; }

        //Dados Grupo Editar/Cadastro

        public static int? idGrupo { get; set; }
        public static string? nomeGrupo { get; set; }
        public static string? grupoAtivo { get; set; }

        //Controle de Formularios
        public static bool? editarUser { get; set; }

        //Diretório do .Ini
        public static string Dir = Directory.GetCurrentDirectory() + "\\MovSoft.ini";

        public Parametros()
        {
            idUser = null;
            nomeUser = null;
            cargoUser = null;
            permissaoUser = null;
            senhaUser = null;
            idCargoUser = null;
            adminUser = null;
            idColab = null;
            nomeColab = null;
            sobrenomeColab = null;
            idSexoColab = -1;
            cpfColab = null;
            nascimentoColab = null;
            nascimentoInputColab = null;
            emailColab = null;
            idCelularColab = null;
            dddColab = null;
            celularColab = null;
            idEndereco = null;
            cep = null;
            logradouro = null;
            numero = null;
            cidade = null;
            bairro = null;
            uf = null;
            idUserEdit = null;
            nomeUserEdit = null;
            cargoUserEdit = null;
            colaboradorUserEdit = null;
            editarUser = null;
        }
    }
}