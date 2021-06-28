using DAOAccess.DAO.DAOImp;
using Gestion_Stock.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAOAccess;
using Service;

namespace DAOAccess.DAO.DAOImp
{
    public class DaoDB : IDaoDB
    {
        MySqlConnection _con;
        MySqlCommand _cmd;
        MySqlDataReader _curseur;
        public DaoDB(DBConnection.DBConnection db)
        {
            _con = db._maConnexion;
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
        }
        public String Ajouter(Article article)
        {

            try
            {
                String idArticle = sqlmethods.getMaxId("Article", "idarticle", _con);

                _cmd.Parameters.Clear();
                String req = "insert into article " +
                    "        values (@ID ,@Label,@Quantite)";
                _cmd.Parameters.AddWithValue("@ID",article.ID );
                _cmd.Parameters.AddWithValue("@Label", article.Label);
                _cmd.Parameters.AddWithValue("@Quantite", article.Quantite);

                _cmd.CommandText = req;
                _cmd.ExecuteNonQuery();
                return idArticle;

            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool Modifier(Article Article)
        {
            try
            {
                _cmd.Parameters.Clear();
                String req = "update  Article set label=@label,quantite=@quantite where id=@id";
                _cmd.Parameters.AddWithValue("@id", Article.ID);
                _cmd.Parameters.AddWithValue("@label", Article.Label);
                _cmd.Parameters.AddWithValue("@quantite", Article.Quantite);

                _cmd.CommandText = req;
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Article> RecupererArticles()

        {
            List<Article> listeArticles = new List<Article>();
            try
            {
                String req = "select * from article";
                _cmd.CommandText = req;
                _curseur = _cmd.ExecuteReader();

                while (_curseur.Read())
                {
                    Article Article = new Article();
                    Article.ID = _curseur.GetString(0);
                    Article.Label = _curseur.GetString(1);
                    Article.Quantite = _curseur.GetString(2);
                    listeArticles.Add(Article);

                }
                _curseur.Close();

            }
            
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return listeArticles;
        }
        public void Supprimer(Article Article)
        {
            try
            {
                _cmd.Parameters.Clear();
                String req = " DELETE FROM  article " +
                             " WHERE ID =" + Article.ID;

                _cmd.CommandText = req;
                _cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}