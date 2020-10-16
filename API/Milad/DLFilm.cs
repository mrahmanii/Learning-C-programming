using Milad.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Milad
{
    public class DLFilm
    {
        MySqlConnection con = new MySqlConnection(DBTransaction.ConnectionString);

        public void SaveFilm(BEFilm film)
        {
            try
            {
                DataTable dt = SearchFile(film.IMDBId);
                if(dt.Rows.Count == 0)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO film (name,year,IMDBScore,IMDBId) VALUES (@name,@year,@IMDBScore,@IMDBId)", con);
                    cmd.Parameters.AddWithValue("@name", film.name);
                    cmd.Parameters.AddWithValue("@year", film.year);
                    cmd.Parameters.AddWithValue("@IMDBScore", film.IMDBScore);
                    cmd.Parameters.AddWithValue("@IMDBId", film.IMDBId);
                    if (con.State != ConnectionState.Open) { con.Open(); }
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("IMDB id is already exists.");
                }                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        public DataTable SearchFile(string id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT name,year,IMDBScore,IMDBId FROM film WHERE IMDBId=@IMDBId", con);
                cmd.Parameters.AddWithValue("@IMDBId", id);
                if (con.State != ConnectionState.Open) { con.Open(); }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }
    }
}