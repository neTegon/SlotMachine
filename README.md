# SlotMachine

Questo programma, sviluppato sia in console che in WPF, il quale, utilizzando una libreria di classi, con ogni moneta che inserisci ti da diritto a una partita nella quale le rotelle girano tre volte e appaiono tre lettere
dell'alfabeto italiano. L'utente può scegliere per le prime due volte se tenere una o due lettere per poi far girare di nuovo le rotelle.
 
Una volta che si ferma:
- se c’è una coppia viene restituita una moneta 
- se c’è un tris di lettere uguali vengono restituite un numero di monete pari alla posizione in ordine alfabetico della lettera del tris(es. tre C corrispondono a 3 monete)
- se ci sono tre lettere consecutive (es. ABC oppure EFG) vengono restituite 50 monete 
- se ci sono tre Z allora è JACKPOT e vengono restituite 100 monetine
altrimenti non viene restituito nulla e si passa alla partita successiva inserendo una nuova monetina.
Le monete vinte possono essere rigiocate oppure riscosse dal giocatore. 
