﻿using System;
using System.Collections.Generic;
using EntitiesLayer;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DataAcessLayer
{
    class DALSQLServer : IDAL
    {
        private String _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Samuel Morel\Documents\GitHub\MonAgenda\MonAgenda\MyAgendaWPF\DataAcessLayer\EventsAgenda.mdf';Integrated Security=True";

        public DALSQLServer()
        {
            
        }


        List<Artiste> IDAL.getAllArtistes()
        {
            DataTable result = Select("select * from Artists;");
            List<Artiste> list = new List<Artiste>();
            Artiste tmp;
            for (int i = 0; i < result.Rows.Count; ++i)
            {
                DataRow row = result.Rows[i];
                tmp = new Artiste(row["NAME"].ToString(), row["BIRTH_DATE"].ToString().Equals("")?new DateTime():DateTime.Parse(row["BIRTH_DATE"].ToString()), row["GUID"].ToString());//(int) row["GUID"]);
                list.Add(tmp);
            }

            return list;
        }

        List<PlanningElement> IDAL.getAllEvenements()
        {
            // pour chaque event
            DataTable events;
            DataTable artist;
            DataRow eventRow;
            DataTable place;
            Evenement tmpEvent;
            Artiste tmpArtist;
            Lieu tmpLieu;
            String birthDate;
            String beginDate;
            String endDate;
            List<PlanningElement> list = new List<PlanningElement>();

            events = Select("SELECT * FROM EVENTS e, EVENT_TYPES et WHERE e.EVENT_TYPE_GUID = et.GUID;");
            for (int e = 0; e < events.Rows.Count; ++e)
            {
                eventRow = events.Rows[e];
                // si c'est un concert
                artist = Select("SELECT a.GUID, a.NAME,a.BIRTH_DATE FROM ARTISTS a, EVENTS_ARTISTS ea WHERE a.GUID = ea.ARTISTS_GUID AND ea.EVENTS_GUID LIKE '" + eventRow["GUID"] + "';");
                
                // les exposition n'ont apparament pas toujours d'artistes associes...
                if (artist.Rows.Count > 0)
                {
                    birthDate = artist.Rows[0]["BIRTH_DATE"].ToString();
                    tmpArtist = new Artiste(artist.Rows[0]["NAME"].ToString(), (birthDate.Equals("NULL")) ? DateTime.Parse(birthDate) : new DateTime(), artist.Rows[0]["GUID"].ToString());
                }
                else
                {
                    tmpArtist = null;
                }

                if (eventRow["DESCRIPTION"].ToString().Equals("Concert"))
                    tmpEvent = new Concert(tmpArtist, eventRow["DESCRIPTION"].ToString(), eventRow["GUID"].ToString(), float.Parse(eventRow["PRICE"].ToString()), eventRow["TITLE"].ToString(), false, 0, 0);
                else
                    tmpEvent = new Exposition(0, tmpArtist, eventRow["DESCRIPTION"].ToString(), eventRow["GUID"].ToString(), float.Parse(eventRow["PRICE"].ToString()), eventRow["TITLE"].ToString());

                place = Select("SELECT p.GUID, p.NAME,p.ADRESS, p.DESCRIPTION, p.NUMBER_PLACES, p.WEB_SITE, p.LOCATION_PERCENT, edp.DATE_BEGIN, edp.DATE_END, edp.RESERVED_PLACES FROM EVENT_DATE_PLACE edp, PLACES p WHERE edp.PLACE_GUID = p.GUID AND edp.EVENT_GUID LIKE '" + eventRow["GUID"] + "';");
                //if (place.Rows.Count > 0)
                //{
                    tmpLieu = new Lieu(place.Rows[0]["GUID"].ToString(), place.Rows[0]["NAME"].ToString(), place.Rows[0]["ADRESS"].ToString(), place.Rows[0]["DESCRIPTION"].ToString(), int.Parse(place.Rows[0]["NUMBER_PLACES"].ToString()), place.Rows[0]["WEB_SITE"].ToString(), float.Parse(place.Rows[0]["LOCATION_PERCENT"].ToString()));
                    beginDate = place.Rows[0]["DATE_BEGIN"].ToString();
                    endDate = place.Rows[0]["DATE_END"].ToString();
                    list.Add(new PlanningElement(DateTime.Parse(beginDate), endDate.Equals("NULL") ? DateTime.Parse(endDate) : new DateTime(), tmpEvent, tmpLieu, int.Parse(place.Rows[0]["RESERVED_PLACES"].ToString())));
                //}
            }

            return list;
        }

        List<Lieu> IDAL.getAllLieux()
        {
            DataTable result = Select("select * from places;");
            List<Lieu> list = new List<Lieu>();
            Lieu tmp;
            for (int i = 0; i < result.Rows.Count; ++i)
            {
                DataRow row = result.Rows[i];
                tmp = new Lieu(row["GUID"].ToString(), row["NAME"].ToString(), row["ADRESS"].ToString(), row["DESCRIPTION"].ToString(), int.Parse(row["NUMBER_PLACES"].ToString()), row["WEB_SITE"].ToString(), float.Parse(row["LOCATION_PERCENT"].ToString()));
                list.Add(tmp);
            }

            return list;
        }

        List<PlanningElement> IDAL.getEvenementsByLieu(String inLieu)
        {
            DataTable events;
            DataTable artist;
            DataTable place;
            Lieu lieu;
            DataRow eventRow;
            Evenement tmpEvent;
            Artiste tmpArtist;
            String birthDate;
            String beginDate;
            String endDate;
            List<PlanningElement> list = new List<PlanningElement>();

            place = Select("select * from PLACES WHERE NAME LIKE '" + inLieu + "';");

            lieu = new Lieu(place.Rows[0]["GUID"].ToString(), inLieu, place.Rows[0]["ADRESS"].ToString(), place.Rows[0]["DESCRIPTION"].ToString(), int.Parse(place.Rows[0]["NUMBER_PLACES"].ToString()), place.Rows[0]["WEB_SITE"].ToString(), float.Parse(place.Rows[0]["LOCATION_PERCENT"].ToString()));

            events = Select("SELECT e.GUID, e.TITLE, e.DESCRIPTION, e.PRICE, e.EVENT_TYPE_GUID, edp.DATE_BEGIN, edp.DATE_END, edp.RESERVED_PLACES FROM PLACES p, EVENT_DATE_PLACE edp, EVENTS e WHERE edp.PLACE_GUID = p.GUID AND e.GUID = edp.EVENT_GUID AND edp.PLACE_GUID LIKE '" + lieu.Guid + "';");
            for (int e = 0; e < events.Rows.Count; ++e)
            {
                eventRow = events.Rows[e];
                // si c'est un concert
                artist = Select("SELECT a.GUID, a.NAME,a.BIRTH_DATE FROM ARTISTS a, EVENTS_ARTISTS ea WHERE a.GUID = ea.ARTISTS_GUID AND ea.EVENTS_GUID LIKE '" + eventRow["GUID"] + "';");

                // les exposition n'ont apparament pas toujours d'artistes associes...
                if (artist.Rows.Count > 0)
                {
                    birthDate = artist.Rows[0]["BIRTH_DATE"].ToString();
                    tmpArtist = new Artiste(artist.Rows[0]["NAME"].ToString(), (birthDate.Equals("NULL")) ? DateTime.Parse(birthDate) : new DateTime(), artist.Rows[0]["GUID"].ToString());
                }
                else
                {
                    tmpArtist = null;
                }

                if (eventRow["DESCRIPTION"].ToString().Equals("Concert"))
                    tmpEvent = new Concert(tmpArtist, eventRow["DESCRIPTION"].ToString(), eventRow["GUID"].ToString(), float.Parse(eventRow["PRICE"].ToString()), eventRow["TITLE"].ToString(), false, 0, 0);
                else
                    tmpEvent = new Exposition(0, tmpArtist, eventRow["DESCRIPTION"].ToString(), eventRow["GUID"].ToString(), float.Parse(eventRow["PRICE"].ToString()), eventRow["TITLE"].ToString());

               
                beginDate = eventRow["DATE_BEGIN"].ToString();
                endDate = eventRow["DATE_END"].ToString();
                list.Add(new PlanningElement(DateTime.Parse(beginDate), endDate.Equals("NULL") ? DateTime.Parse(endDate) : new DateTime(), tmpEvent, lieu, int.Parse(eventRow["RESERVED_PLACES"].ToString())));
            }
            return list;
        }

        Utilisateur IDAL.getUtilisateurByLogin(string login)
        {
            Utilisateur user;
            DataTable data = Select("Select LOGIN, PASSWORD from USERS WHERE LOGIN LIKE '" + login + "';");
            if (data.Rows.Count != 0)
                user = new Utilisateur(data.Rows[0]["LOGIN"].ToString(), data.Rows[0]["PASSWORD"].ToString());
            else
                user = new Utilisateur();
            return user;
        }



        DataTable Select(string requete)
        {
            DataTable result = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(requete, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(result);
            }

            return result;
        }


        void IDAL.update(IList<PlanningElement> New, IList<PlanningElement> Old)
        {
            // Nos deux listes sont triées, on a qu'a les parcourir dans l'ordre de GUID

            for (int i = 0; i < New.Count; ++i)
            {
                // Si les evenements sont différents
                if (!New[i].Equals(Old[i]))
                {

                    if (New[i].Evenement.Guid.Equals(Old[i].Evenement.Guid))
                    {
                        // si les deux evenements sont différents c'est qu'une ligne a été supprimée ou insérée
                        Select("UPDATE EVENT_DATE_PLACE " +
                                "SET RESERVED_PLACES = " + New[i].NombresPlacesReservees + ", " +
                                "PLACE_GUID = '" + New[i].Lieu.Guid + "' " +
                                "WHERE EVENT_GUID = '" + New[i].Evenement.Guid + "';");

                        Select("UPDATE EVENTS " +
                                "SET TITLE = '" + New[i].Evenement.Titre + "', " +
                                "DESCRIPTION = '" + New[i].Evenement.Description + "' " +
                                "WHERE GUID = '" + New[i].Evenement.Guid + "';");
                    }
                    else
                    {
                        // Suppression supprime presque tout donc desactivée...
                        // Select("DELETE FROM EVENT_DATE_PLACE WHERE EVENT_GUID = '" + Old[i].Evenement.Guid + "';");
                        // Select("DELETE FROM EVENTS_ARTISTS WHERE EVENTS_GUID = '" + Old[i].Evenement.Guid + "';");
                        // Select("DELETE FROM EVENTS WHERE GUID = '" + Old[i].Evenement.Guid + "';");
                    }
                }
            }
        }


        public int getReservedPlaces(PlanningElement plan)
        {
            return SelectByStorageProcedure(plan.Lieu.Guid, plan.Evenement.Guid, plan.DateDebut);
        }

        private int SelectByStorageProcedure(String place, String evenement, DateTime Date)
        {
            int result;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "GET_AVAIABLE_PLACES";

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@placeGuid", place);
                sqlCommand.Parameters.AddWithValue("@eventGuid", evenement);
                sqlCommand.Parameters.AddWithValue("@dateGuid", Date);

                SqlParameter retour = sqlCommand.Parameters.Add("@returnValue", SqlDbType.Int);

                retour.Direction = ParameterDirection.ReturnValue;

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(sqlCommand.Parameters["@returnValue"].Value.ToString());

                sqlConnection.Close();
            }
            return result;
        }

        public string reservePlace(PlanningElement plan, int nbPlaces)
        {
            throw new NotImplementedException();
        }
    }
}
