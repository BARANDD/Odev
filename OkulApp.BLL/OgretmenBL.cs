using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    internal class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen og)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",og.Ad),
                                  new SqlParameter("@Soyad",og.Soyad),
                                  new SqlParameter("@Tc",og.Tc)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgretmen (Ad,Soyad,Tc) values (@Ad,@Soyad,@Tc)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {


            }
        }
    }
}
