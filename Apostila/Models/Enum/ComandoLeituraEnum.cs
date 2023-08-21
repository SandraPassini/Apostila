namespace Apostila.Models.Enum
{
    public class ComandoLeituraEnum
    {
        public ComandoLeituraEnum()
        {
            
        }
        enum comandoLer
            {
                //O sistema deverá apresentar as próximas 11 linhas do arquivo, iniciando na linha subseqüente a linha inicial que estava apresentando anteriormente.
                //Por exemplo: se o usuário estiver visualizando as linhas de 25 a 35, ao pressionar esta tecla, o sistema deverá apresentar as linhas de 26 a 36. 
                ArrowDown = 1,

                //O sistema deverá apresentar as 11 linhas anteriores do arquivo, iniciando na linha anterior a linha inicial que estava apresentando
                //anteriormente. Por exemplo: se o usuário estiver visualizando as linhas de 25 a 35, ao pressionar esta tecla, o sistema deverá apresentar as linhas de
                //24 a 34. 
                ArrowUP = 2,

                //O sistema deverá apresentar as próximas 11 linhas do arquivo, iniciando na linha posterior a linha final que estava apresentando anteriormente.
                //Por exemplo: se o usuário estiver visualizando as linhas de 25 a 35, ao pressionar esta tecla, o sistema deverá apresentar as linhas de 36 a 46. 
                PageDown = 3,

                //O sistema deverá apresentar as 11 linhas anteriores do arquivo, finalizando na linha anterior a linha final que estava apresentando anteriormente.
                //Por exemplo: se o usuário estiver visualizando as linhas de 25 a 35, ao pressionar esta tecla, o sistema deverá apresentar as linhas de 14 a 24. 
                PageUP = 4,

                //O sistema aguardará que o usuário insira o numero da linha do arquivo que se deseja visualizar, neste caso, deverá ser apresentado as 5 linhas
                //anteriores e as 5 posteriores a linha que usuário indicou. Por exemplo: se o usuário escolher a linha 30, o sistema deverá apresentar as linhas de 25 a 35. 
                L = 5 
            }
    }
}