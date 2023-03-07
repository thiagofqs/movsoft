﻿using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class GruposBLL
    {
        AcessoBancoDados db = new();

        public void CadastrarGrupo(GruposDTO gruposDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"
                insert into grupos () values
                (default,'{gruposDTO.NomeGrupo}', 'S')
                ";
                db.ExecutarComandoSQL(comando);
            }
            catch(Exception ex) 
            { 
            MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarGrupos()
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = @"
                select id_grupo as 'ID', grupo as 'Grupo' from grupos
                where grupos.ativo = 'S'
                order by id_grupo asc;
                ";
                dataTable = db.RetDataTable(comando);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void PegarDados(int idGrupo)
        {
            try
            {
                db.Conectar();
                string comando = $@"
                select id_grupo, grupo, ativo from grupos
                where id_grupo = {idGrupo}; 
                ";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idGrupo = dr.GetInt32(0);
                Parametros.Grupo = dr.GetString(1);
                Parametros.GrupoAtivo = dr.GetString(2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarGrupo(GruposDTO gruposDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"
                update grupos
                set grupo = '{gruposDTO.NomeGrupo}', ativo = 'S'
                where id_grupo = {gruposDTO.IdGrupo};
                ";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarGrupo(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(@$"
                select id_grupo as 'ID', grupo as 'Grupo' from grupos
                where id_grupo = '{pesquisa}' or grupo like concat('%', '{pesquisa}', '%');
                ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
    }
}
