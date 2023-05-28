using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using KursWork.Models;
using KursWork.Views;
using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KursWork.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private Link _link;
        private ObservableCollection<DFigure> Coll;
        private int _num = 0;
        private bool Pflag = false; 
        private int selScheme = 0;
        private string _projName;
        private DModel dModelForDelete;
        public string ProjName
        {
            get => _projName;
            set => SetProperty(ref _projName, value);
        }
        public MainWindowViewModel(MainWindow mw)
        {
            Coll = new ObservableCollection<DFigure>();
        }
        public int Num
        {
            get => _num;
            set => SetProperty(ref _num, value);
        }
        void SetAnd()
        {
            selScheme = 0;
        }
        void SetOr()
        {
            selScheme = 1;
        }
        void SetNt()
        {
            selScheme = 2;
        }
        void SetXor()
        {
            selScheme = 3;
        }
        void VSourse()
        {
            selScheme = 4;
        }
        void MultiP()
        {
            selScheme = 6;
        }
        void OutPut()
        {
            selScheme = 5;
        }
        public void ResetCOLL()
        {
            bool flag = false;
            for(int qwe = 0; qwe < Num; qwe++) { 
            for(int i = 0; i < COLL.Count(); i++)
            {
                if (COLL[i] is DModel dModel)
                {
                    if (dModel is Multipleks mks && mks.SideC==false) { mks.Side = false; }
                    if(dModel.FInpC == false) { dModel.FInp = false; }
                    else
                    {
                        for(int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link) 
                            { 
                                if(link.SLinkNumb == dModel.Numb) 
                                { 
                            
                                    if(link.SInpNumb == 2)
                                    {
                                        if(COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                    if(link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                            
                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.SLinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.SLinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(dModel.SInpC == false) { dModel.SInp = false; }
                    else
                    {
                        for (int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link)
                            {
                                if (link.SLinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }

                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                            }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (dModel.OInpC == false) { dModel.BOut = false; }
                    else
                    {
                        for (int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link)
                            {
                                if (link.SLinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                            }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }

                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            }
            for (int i = 0; i < COLL.Count(); i++)
            {
                if (COLL[i] is Lamp lamp)
                {
                    if (lamp.FInp == true) lamp.VisibleQ = true;
                    if (lamp.FInp == false) lamp.VisibleQ = false;
                }
            }
        }
        void DelLink()
        {
            if(SelLink != null)
            {
                COLL[SelLink.Numb] = null;
                if (COLL[SelLink.SLinkNumb] is DModel dModel)
                {
                    if (SelLink.SInpNumb == 0) { dModel.FInpC = false; }
                    if (SelLink.SInpNumb == 1) { dModel.SInpC = false; }
                    if (SelLink.SInpNumb == 2) { dModel.OInpC = false; }
                    if (SelLink.SInpNumb == 3 && dModel is Multipleks mx) { mx.SideC = false; }
                }
                if (COLL[SelLink.ELinkNumb] is DModel dModel2)
                {
                    if (SelLink.EInpNumb == 0) { dModel2.FInpC = false; }
                    if (SelLink.EInpNumb == 1) { dModel2.SInpC = false; }
                    if (SelLink.EInpNumb == 2) { dModel2.OInpC = false; }
                    if (SelLink.EInpNumb == 3 && dModel2 is Multipleks mx) { mx.SideC = false; }
                }
                ResetCOLL();
            }
        }
        void DelDmod()
        {
            if (DModelForDelete != null && COLL[DModelForDelete.Numb] is DModel)
            {
                COLL[DModelForDelete.Numb] = null;
            }
        }
        public int SelScheme
        {
            get => selScheme;
        }
        public DModel DModelForDelete
        {
            get => dModelForDelete;
            set => SetProperty(ref dModelForDelete, value);
        }
        public Link SelLink
        {
            get => _link;
            set => SetProperty(ref _link, value);
        }
        public ObservableCollection<DFigure> COLL
        {
            get => Coll;
            set => SetProperty(ref Coll, value);
        }
        Point StrToPoint(string str)
        {
            string[] wordsSt = str.Split(new char[] { ',' });
            int resultSt1 = Convert.ToInt32(wordsSt[0]);
            int resultSt2 = Convert.ToInt32(wordsSt[1]);
            Point res = new Point(resultSt1, resultSt2);

            return res;
        }
        public void Save()
        {
            using (var connection = new SqliteConnection($"Data Source=C:\\Users\\Rik\\source\\repos\\KursWork\\{ProjName}.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT,Name TEXT,BOut INTEGER,FInp INTEGER,FInpC INTEGER,FStartPoint TEXT,Numb INTEGER,OInpC INTEGER,OStartPoint TEXT,SInp INTEGER,SInpC INTEGER,SStartPoint TEXT,StartPoint TEXT,SidePoint TEXT,SideC INTEGER,Side INTEGER, VisibleQ INTEGER,FPoint TEXT,SPoint TEXT,SLinkNumb TEXT, ELinkNumb TEXT,SInpNumb TEXT,EInpNumb TEXT)";
                command.ExecuteNonQuery();
                for(int i = 0;i<COLL.Count();i++)
                {
                    if (COLL[i] is DModel dModel) 
                    { 
                        if(dModel is AndM ands)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}')";
                        }
                        if (dModel is Lamp lamp)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint,VisibleQ) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}','{lamp.VisibleQ}')";
                        }
                        if (dModel is Multipleks mx)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint,SidePoint,SideC,Side) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}','{mx.SidePoint}','{mx.SideC}','{mx.Side}')";
                        }
                        if (dModel is NoT nt)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}')";
                        }
                        if (dModel is OrM orm)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}')";
                        }
                        if (dModel is VSourse vs)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}')";
                        }
                        if (dModel is XoR xoR)
                        {
                            command.CommandText = $"INSERT INTO Catalog (Name,BOut,FInp,FInpC,FStartPoint,Numb,OInpC,OStartPoint,SInp,SInpC,SStartPoint,StartPoint) VALUES ('{dModel.Name}','{dModel.BOut}','{dModel.FInp}','{dModel.FInpC}','{dModel.FStartPoint}','{dModel.Numb}','{dModel.OInpC}','{dModel.OStartPoint}','{dModel.SInp}','{dModel.SInpC}','{dModel.SStartPoint}','{dModel.StartPoint}')";
                        }
                        command.ExecuteNonQuery();
                    }
                    if (COLL[i] is Link link)
                    {
                        command.CommandText = $"INSERT INTO Catalog (Name,Numb,FPoint,SPoint,SLinkNumb,ELinkNumb,SInpNumb,EInpNumb) VALUES ('{link.Name}','{link.Numb}','{link.FPoint}','{link.SPoint}','{link.SLinkNumb}','{link.ELinkNumb}','{link.SInpNumb}','{link.EInpNumb}')";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public void Read()
        {
            bool BoutB;
            bool FInpB;
            bool FInpCB;
            Point FStartPointB;
            Int64 Numb;
            bool OInpCB;
            Point OStartPointB;
            bool SInpB;
            bool SInpCB;
            Point SStartPointB;
            Point StartPointB;
            Point SidePointB = new Point(0, 0);
            bool SideCB = false;
            bool SideB = false;
            bool VISQ = true;
            Point FPointB = new Point(0,0);
            Point SPointB = new Point(0,0);
            Int64 SLinkNumbB=0;
            Int64 ELinkNumbB=0;
            Int64 SInpNumbB=0;
            Int64 EInpNumbB=0;
            COLL.Clear();
            string sqlExpression = "SELECT * FROM Catalog";
            using (var connection = new SqliteConnection($"Data Source=C:\\Users\\Rik\\source\\repos\\KursWork\\{ProjName}.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            string name = (string)reader["Name"];
                            string Bout = (string)reader["BOut"];
                            string FInp = (string)reader["FInp"];
                            string FInpC = (string)reader["FInpC"];
                            string OInpC = (string)reader["OInpC"];
                            string OStartPoint = (string)reader["OStartPoint"];
                            string FStartPoint = (string)reader["FStartPoint"];
                            string SInp = (string)reader["SInp"];
                            string SInpC = (string)reader["SInpC"];
                            string SStartPoint = (string)reader["SStartPoint"];
                            string StartPoint = (string)reader["StartPoint"];
                            object VisLamp = reader["VisibleQ"];
                            Numb = (Int64)reader["Numb"];
                            object SidePoint = reader["SidePoint"];
                            object SideC = reader["SideC"];
                            object Side = reader["Side"];
                            object FPoint = reader["FPoint"];
                            object SPoint = reader["SPoint"];
                            object SInpNumb = reader["SInpNumb"];
                            object SLinkNumb = reader["SLinkNumb"];
                            object ELinkNumb = reader["ELinkNumb"];
                            object EInpNumb = reader["EInpNumb"];
                            if (Bout == "False") BoutB = false; else BoutB = true;
                            if (FInp == "False") FInpB = false; else FInpB = true;
                            if (FInpC == "False") FInpCB = false; else FInpCB = true;
                            FStartPointB = StrToPoint(FStartPoint);
                            if (OInpC == "False") OInpCB = false; else OInpCB = true;
                            OStartPointB = StrToPoint(OStartPoint);
                            if (SInp == "False") SInpB = false; else SInpB = true;
                            if (SInpC == "False") SInpCB = false; else SInpCB = true;
                            SStartPointB = StrToPoint(SStartPoint);
                            StartPointB = StrToPoint(StartPoint);
                            if(VisLamp != DBNull.Value)
                            {
                                if ((string)VisLamp == "False") VISQ = false; else VISQ = true;
                            }
                            if (SidePoint != DBNull.Value)
                            {
                                SidePointB = StrToPoint((string)SidePoint);
                            }
                            if (Side != DBNull.Value)
                            {
                                if ((string)Side == "False") SideCB = false; else SideCB = true;
                            }
                            if (SideC != DBNull.Value)
                            {
                                if ((string)SideC == "False") SideB = false; else SideB = true;
                            }
                            if (FPoint != DBNull.Value)
                            {
                                FPointB = StrToPoint((string)FPoint);
                            }
                            if (SPoint != DBNull.Value)
                            {
                                SPointB = StrToPoint((string)SPoint);
                            }
                            if(SInpNumb != DBNull.Value)
                            {
                                SInpNumbB = (long)SInpNumb;
                            }

                            if (SLinkNumb != DBNull.Value)
                            {
                                SLinkNumbB = (long)SLinkNumb;
                            }

                            if (ELinkNumb != DBNull.Value)
                            {
                                ELinkNumbB = (long)ELinkNumb;
                            }
                            if (EInpNumb != DBNull.Value)
                            {
                                EInpNumbB = (long)EInpNumb;
                            }
                            if (name == "And")
                            {
                                COLL.Add(new AndM
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB
                                }) ; 
                            }
                            if (name == "Lamp")
                            {
                                COLL.Add(new Lamp
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB,
                                    VisibleQ = VISQ

                                }) ;
                            }
                            if (name == "Multipleks")
                            {
                                COLL.Add(new Multipleks
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB,
                                    SidePoint = SidePointB,
                                    SideC = SideCB,
                                    Side = SideB
                                }) ;
                            }
                            if (name == "Not")
                            {
                                COLL.Add(new NoT
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB
                                });
                            }
                            if (name == "Or")
                            {
                                COLL.Add(new OrM
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB
                                });
                            }
                            if (name == "VS")
                            {
                                COLL.Add(new VSourse
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB
                                });
                            }
                            if (name == "Xor")
                            {
                                COLL.Add(new XoR
                                {
                                    Name = name,
                                    BOut = BoutB,
                                    FInp = FInpB,
                                    FInpC = FInpCB,
                                    FStartPoint = FStartPointB,
                                    Numb = (int)Numb,
                                    OInpC = OInpCB,
                                    OStartPoint = OStartPointB,
                                    SInp = SInpB,
                                    SInpC = SInpCB,
                                    StartPoint = StartPointB
                                });
                            }
                            if(name == "Link")
                            {
                                COLL.Add(new Link
                                {
                                    Numb = (int)Numb,
                                    FPoint = FPointB,
                                    SPoint = SPointB,
                                    SLinkNumb = (int)SLinkNumbB,
                                    ELinkNumb = (int)ELinkNumbB,
                                    SInpNumb = (int) SInpNumbB,
                                    EInpNumb = (int) ELinkNumbB,
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}
