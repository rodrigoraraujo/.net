using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimsAuthWithExternalSTS.IdentityModel
{
    public class SWClaimsTypes
    {
        //Pessoa Representada

        /// <summary>
        /// TipoPessoaRepresentada: http://prodamsp/security/messagetype/identity/claims/tipopessoarepresentada <br />
        /// Define o tipo de pessoa que está sendo representada na delegação de acesso ou na representação legal (procuração eletrônica).
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// Recebe o tipo do próprio usuário autenticado caso ele tenha acessado utilizado a opção "Titular" na tela de seleção de representações ou  caso não tenha passado por essa tela
        /// </summary>
        public const string TipoPessoaRepresentada = @"http://prodamsp/security/messagetype/identity/claims/tipopessoarepresentada"; // Campo 1

        /// <summary>
        /// CodigoPessoaRepresentada: http://prodamsp/security/messagetype/identity/claims/codigopessoarepresentada <br />
        /// CPF ou CNPJ da pessoa representada na delegação de acesso ou na representação legal (procuração eletrônica) <br />
        /// Recebe o CPF/CNPJ do próprio usuário autenticado caso ele tenha acessado utilizado a opção "Titular" na tela de seleção de representações ou  caso não tenha passado por essa tela <br />
        /// </summary>
        public const string CodigoPessoaRepresentada = @"http://prodamsp/security/messagetype/identity/claims/codigopessoarepresentada"; // Campo 1

        /// <summary>
        /// NomePessoaRepresentada: http://prodamsp/security/messagetype/identity/claims/nomepessoarepresentada <br />
        /// Nome da pessoa representada na delegação de acesso ou na representação legal (procuração eletrônica) <br />
        /// Recebe o nome do próprio usuário autenticado caso ele tenha acessado utilizado a opção "Titular" na tela de seleção de representações ou  caso não tenha passado por essa tela <br />
        /// </summary>
        public const string NomePessoaRepresentada = @"http://prodamsp/security/messagetype/identity/claims/nomepessoarepresentada"; // Campo 2

        /// <summary>
        /// IndicadorRepresentadoExisteBP: http://prodamsp/security/messagetype/identity/claims/indicadorrepresentadoexistebp <br />
        /// Indica se a pessoa representada na delegação de acesso ou na representação legal (procuração eletrônica) existe na Base de Pessoas.
        /// <list type="SinNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string IndicadorRepresentadoExisteBP = @"http://prodamsp/security/messagetype/identity/claims/indicadorrepresentadoexistebp"; // Campo 8

        /// <summary>
        /// IndicadorRepresentadoExisteSWEB: http://prodamsp/security/messagetype/identity/claims/indicadorrepresentadoexistesw <br />
        /// Indica se a pessoa representada na delegação de acesso ou na representação legal (procuração eletrônica) é usuária do Senhaweb (tem senha).
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string IndicadorRepresentadoExisteSWEB = @"http://prodamsp/security/messagetype/identity/claims/indicadorrepresentadoexistesw"; // Campo 12


        //Pessoa Logada

        /// <summary>
        /// TipoPessoa: http://prodamsp/security/messagetype/identity/claims/tipopessoa <br />
        /// Define o tipo de pessoa autenticada 
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string TipoPessoa = @"http://prodamsp/security/messagetype/identity/claims/tipopessoa"; // Campo 4

        /// <summary>
        /// CodigoPessoa: http://prodamsp/security/messagetype/identity/claims/codigopessoa <br />
        /// CPF ou CNPJ da pessoa autenticada <br />
        /// </summary> 
        public const string CodigoPessoa = @"http://prodamsp/security/messagetype/identity/claims/codigopessoa"; // Campo 4

        /// <summary>
        /// NomePessoa: http://prodamsp/security/messagetype/identity/claims/nomepessoa <br />
        /// Nome da Pessoa autenticada <br />
        /// </summary>
        public const string NomePessoa = @"http://prodamsp/security/messagetype/identity/claims/nomepessoa"; // Campo 5

        /// <summary>
        /// TipoLogin: http://prodamsp/security/messagetype/identity/claims/tipologin <br />
        /// Tipo de login efetuado
        /// <list type="tipos">
        ///     <item>UNDEFINED = 0</item>
        ///     <item>SENHA = 1</item>
        ///     <item>SENHACNPJ = 2</item>
        ///     <item>CERTIFICADO = 4</item>
        /// </list>
        /// </summary>
        public const string TipoLogin = @"http://prodamsp/security/messagetype/identity/claims/tipologin"; // Campo 6        

        /// <summary>
        /// IndicadorPessoaExisteBP: http://prodamsp/security/messagetype/identity/claims/indicadorpessoaexistebp <br />
        /// Indica se a pessoa autenticada existe na Base de Pessoas <br />
        /// (Pode não existir se o login for feito po certificado digital e a integração com a RFB estiver desabilitada para inserir a pessoa ao se autenticar)
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string IndicadorPessoaExisteBP = @"http://prodamsp/security/messagetype/identity/claims/indicadorpessoaexistebp"; // Campo 3

        /// <summary>
        /// IndicadorPessoaExisteSWEB: http://prodamsp/security/messagetype/identity/claims/indicadorpessoaexistesweb <br />
        /// Indica se a pessoa representada na delegação de acesso ou na representação legal (procuração eletrônica) é usuária do Senhaweb (tem senha) <br />
        /// (Pode não ser usuário Senhaweb, se efetua login somente com certificado digital
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string IndicadorPessoaExisteSWEB = @"http://prodamsp/security/messagetype/identity/claims/indicadorpessoaexistesweb";

        /// <summary>
        /// IndicadorRelacao: http://prodamsp/security/messagetype/identity/claims/indicadorpessoaautenticada <br />
        /// Define a relação entre a pessoa autenticada e a pessoa selecionada para a representação.
        /// <list type="relacao">
        ///     <item>"T" = login do próprio titular (sem representação);</item>
        ///     <item>"N" = não identificado (quando o login é por certificado digital e-CNPJ e a pessoa física do certificado não é o responsável legal da RFB);</item>
        ///     <item>"R" = responsável legal (quando o login é de PF e a pessoa seleciona uma empresa de sua responsabilidade legal para representar);</item>
        ///     <item>"A" = autorizado por delegação (quando o login é de PF e a pessoa seleciona uma empresa que pode representar via delegação de acesso);</item>
        /// </list>
        /// </summary>
        public const string IndicadorRelacao = @"http://prodamsp/security/messagetype/identity/claims/indicadorpessoaautenticada"; //Campo 7

        /// <summary>
        /// Recursos: http://prodamsp/security/messagetype/identity/claims/serialized/recursos <br />
        /// Lista de recursos cadastrados e relacionados ao usuário autenticado e representação selecionada  <br />
        /// A Lista de recursos é nula quando o tipo de relacionamento é "T", "N" ou "R" (pois significa que a pessoa autenticad apode acessar tudo relacionado ao CPF/CNPJ selecionado na tela de representação). <br />
        /// A Lista contém uma estrutura json contendo os atributos principais de cada recurso que o usuário pode ter acesso, dentro do sistema que está sendo acessado. <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager <br />
        /// * Caso haja necessidade de identificar se um recurso é acesssível para um usuário, os Relying Parties podem acessar o webservice de consulta de recursos do usuário. Contatar equipe Senhaweb para detalhes. <br />
        /// </summary>
        public const string Recursos = @"http://prodamsp/security/messagetype/identity/claims/serialized/recursos"; //Campo 9        

        /// <summary>
        /// CertificadoDigital: http://prodamsp/security/messagetype/identity/claims/serialized/certificado <br />
        /// Estrutura json contendo os principais atributos do Certificado digital utilizado na autenticação <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager <br />
        /// </summary>
        public const string CertificadoDigital = @"http://prodamsp/security/messagetype/identity/claims/serialized/certificado"; //Campo 10 (Serializado)        

        /// <summary>
        /// CodigoSessaoUsuarioAutenticado: http://prodamsp/security/messagetype/identity/claims/codigosessaousuarioautenticado <br />
        /// Código gerado pelo Senhaweb para identificar e registrar as ações do usuário. <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager <br />
        /// </summary>
        public const string CodigoSessaoUsuarioAutenticado = @"http://prodamsp/security/messagetype/identity/claims/codigosessaousuarioautenticado"; //Campo 11

        /// <summary>
        /// ExisteExcecaoCertificado: http://prodamsp/security/messagetype/identity/claims/existeexcecaocertificado <br />
        /// Indica se o usuário faz parte da lista de pessoas que podem acessar funcionalidades restritas para acesso via certificado digital utilizando apenas senha.
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        /// </list>
        /// </summary>
        public const string ExisteExcecaoCertificado = @"http://prodamsp/security/messagetype/identity/claims/existeexcecaocertificado";

        /// <summary>
        /// CNPJDetentoraSW: http://prodamsp/security/messagetype/identity/claims/cnpjdetentorasw < <br />
        /// Contém o CNPJ da unidade empresarial que solicitou e desbloqueou a senhaweb da empresa (raiz de CNPJ) <br />
        /// OBS: A senha de PJ é única para todas as unidades de uma empresa, porém o Senhaweb registra qual a unidade detentora da senha. <br />
        /// O atributo pode ser utilizado para acessar dados específicos dessa unidade, nos webservices de consulta de dados cadastrais, caso haja necessidade. <br />
        /// </summary>
        public const string CNPJDetentoraSW = @"http://prodamsp/security/messagetype/identity/claims/cnpjdetentorasw";

        //Configuração

        /// <summary>
        /// PaginaInicialRelyingParty: http://prodamsp/security/messagetype/identity/claims/paginainicialrelyingparty <br />
        /// Contém a página inicial da RP configurada no arquivo RelyingParties.xml <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager <br />
        /// </summary>
        public const string PaginaInicialRelyingParty = @"http://prodamsp/security/messagetype/identity/claims/paginainicialrelyingparty";

        /// <summary>
        /// SiglaRelyingParty: http://prodamsp/security/messagetype/identity/claims/siglarelyingparty <br />
        /// Contém o código do sistema RP configurada no arquivo RelyingParties.xml <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager <br />
        /// </summary>
        public const string SiglaRelyingParty = @"http://prodamsp/security/messagetype/identity/claims/siglarelyingparty";

        /// <summary>
        /// IndicadorTemRepresentacoes: http://prodamsp/security/messagetype/identity/claims/indicadortemrepresentacoes <br />
        /// Indica se o usuário autenticado possui pessoas que pode representar (no mínimo 1) <br />
        /// * Atributo usado internamente pelo componente SenhawebAuthorizationManager e na barra de navegação do Senhaweb <br />
        /// <list type="SimNao">
        ///     <item>Sim = "S"</item>
        ///     <item>Não = "N"</item>
        ///     <item>Desabilitado = "D" (indica a situação de login por certidicado digital de PJ, onde o usuário pode ter representações, mas não pode trocar)</item>
        ///     <item>Pessoa Jurídica = "J" (indica um logim via senha de pessoa jurídica, o que impossibilita a identificação de existência de representações)</item>
        /// </list>
        /// </summary>
        public const string IndicadorTemRepresentacoes = @"http://prodamsp/security/messagetype/identity/claims/indicadortemrepresentacoes";

        /// <summary>
        /// urlAposLogout: http://prodamsp/security/messagetype/identity/claims/urlaposlogout <br />
        /// Guarda a URL que deverá ser utilizada para redirecionar a aplicação após logout <br />
        /// Valor configurado no arquivo RelyingParties.xml <br />
        /// * Atributo usado internamente pelo STS <br />
        /// </summary>
        public const string urlAposLogout = @"http://prodamsp/security/messagetype/identity/claims/urlaposlogout";
    }
}