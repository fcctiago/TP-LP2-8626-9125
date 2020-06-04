/*
 * LPII
 * Pedro Gomes nº8626
 * Tiago Cruz nº9125
 * 
 * Libraria de exceptions
 * Manipulação excepções a erros
 */
using System;

namespace Excepcoes
{
    public class InsereException : ApplicationException
    {
        public InsereException() : base("Inserção Inválida")
        {
        }

        public InsereException(string s) : base(s) { }


        public InsereException(string s, Exception e)
        {
            throw new InsereException("ERRO: " + s + " - " + e.Message);
        }
    }
}
