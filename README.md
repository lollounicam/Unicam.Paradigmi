# Progetto del modulo di programmazione eterprise.

Il seguente progetto riguarda la realizzazione di un API che permette la gestione di una libreria.

## Descrizione del Progetto

Benvenuti nel mio progetto di Web Api, fatto per semplificare la gestione del catalogo di una libreria! Questa applicazione offre un'ampia gamma di funzionalità per la gestione degli utenti, dei libri e delle categorie, per testarle abbiamo implementato Swagger.

## Funzionalità Principali

- Gestione degli Utenti: Creazione di utenti con informazioni di base come email, nome, cognome e password.

- Gestione dei Libri: Caricamento, modifica ed eliminazione di libri con informazioni dettagliate come nome, autore, data di pubblicazione, editore e categorie associate.

- Gestione delle Categorie: Creazione e eliminazione di categorie uniche, garantendo che non ci siano duplicati nel catalogo e che le categorie siano vuote al momento dell'eliminazione.

- Autenticazione Sicura: Proteggi l'accesso alle API con un sistema di autenticazione sicuro, implementato usando JwtAuthentication.

- Ricerca Avanzata: Ricerca libri in base a categorie, nome del libro, data di pubblicazione e autore, con supporto per la paginazione dei risultati.

## API Disponibili

Le seguenti API sono disponibili per l'utilizzo:

- Creazione di Utente: Crea un nuovo utente.
- Autenticazione: Permette agli utenti di accedere all'applicazione.
- Creazione di Categoria: Aggiungi nuove categorie al catalogo.
- Eliminazione di Categoria: Rimuovi categorie vuote dal sistema.
- Caricamento di Libro: Aggiungi nuovi libri al catalogo.
- Modifica di Libro: Aggiorna le informazioni di un libro esistente.
- Eliminazione di Libro: Rimuovi libri dal catalogo.
- Ricerca di Libro: Cerca libri utilizzando filtri come categoria, nome, data di pubblicazione e autore, con supporto per la paginazione.

## Come testare il progetto:

1. Clonare la repository con `git clone https://github.com/lollounicam/Unicam.Paradigmi.git`.
2. Configurare il database tramite il dump inserito [qui](https://github.com/lollounicam/Unicam.Paradigmi/blob/ff4f38bcac9e0032fe72bf6d4850f0ddb8f48cc8/dump.sql)
3. Aprire la soluzione nella cartella e avviare il progetto tramite il vostro IDE di sviluppo.
4. Oppure usare `dotnet run`.
5. Esplorate le API: Utilizza gli endpoint API per gestire i libri le categorie e gli utenti.

Lorenzo Pompili
