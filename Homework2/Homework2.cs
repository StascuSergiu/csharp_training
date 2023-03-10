// See https://aka.ms/new-console-template for more information
using Homework2;

Participant p1 =    new Participant("p1",   1,  5);
Participant p2 =    new Participant("p2",   2,  9);
Participant p3 =    new Participant("p3",   3,  1);
Participant p4 =    new Participant("p4",   4,  7);
Participant p5 =    new Participant("p5",   5,  7);
Participant p6 =    new Participant("p6",   6,  3);
Participant p7 =    new Participant("p7",   7,  8);
Participant p8 =    new Participant("p8",   8,  4);
Participant p9 =    new Participant("p9",   9,  10);
Participant p10 =   new Participant("p10",  10, 9);
Participant p11 =   new Participant("p11",  11, 2);
Participant p12 =   new Participant("p12",  12, 5);

Contest eurovision = new Contest();

eurovision.AddNewParticipantAtPozitionInList(p1, 1);
eurovision.AddNewParticipantAtPozitionInList(p2, 1);
eurovision.AddNewParticipantAtPozitionInList(p3, 3);
eurovision.ChangeScoreById(2, 2);
eurovision.ChangeScoreById(3, 10);
eurovision.ChangeScoreById(7, 3);
eurovision.PrintParticipants();


