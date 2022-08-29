insert into Chef
values ('1', 'Marco Pierre White',NULL,'Se spune că Chef White este un deschizător de drumuri pentru o mulțime de alți bucătari celebri. El este un bine-cunoscut bucătar britanic de televiziune, și supranumit „părintele bucătăriei contemporane”.'),
	   ('2', 'Anthony Bourdain','Culinary School of America','Anthony Bourdain a ajuns la statutul de bucătar celebru prin emisiunile sale de televiziune extrem de populare precum „The Layover”, „A Cook’s Tour” etc. De asemenea, a apărut ca jurat în mai multe emisiuni de televiziune.'),
	   ('3', 'Paul Bocuse',NULL,'Paul este o legendă în Franța și în multe alte părți ale lumii. El a îndrumat mulți bucătari care au continuat să creeze propriile mărci de succes. Industria ospitalității este încă strâns legată de conceptele sale inovatoare care au ajutat mult dezvoltarea acestei industrii.'),
	   ('4', 'Gordon James Ramsay',NULL,'Criticul culinar mereu furios Gordon Ramsay este unul dintre cei mai faimoși bucătari de la TV, cunoscut pentru cuvintele dure pe care le împărtășește concurenților din emisiunea sa TV Hell’s Kitchen. Emisiunea a avut un succes atât de mare încât Ramsay a continuat să găzduiască alte câteva emisiuni, inclusiv Kitchen Nightmares, Master Chef și The F Word. A fost cândva fotbalist, dar a renunțat la sport pentru a deveni bucătar după ce s-a accidentat la fotbal. Acum deține o mulțime de restaurante de top pe tot globul.'),
	   ('5', 'Alain Ducasse',NULL,'Acesta este un alt bucătar francez extrem de popular, care este primul chef celebru care a deschis câteva restaurante de succes de 3 stele Michelin. 3 stele Michelin pentru un restaurant sunt precum 5 stele pentru hoteluri.'),
	   ('6', 'Maria Constantin', Null,Null);

insert into Addresses
values('1','New York','USA','Murberry','1', 6 ),
	  ('2','Sofia','Bulgaria','Atom','3', 53 ),
	  ('3','Bucuresti','Romania','Tractorului','2', 112 ),
	  ('4','Londra','UK','Pine', '4', 76),
	  ('5','Cluj','Romania','Panselutelor', '6', 3),
	  ('6','Paris','Franta','Avenue Victor Hugo', '5', 98);

insert into Recipes
values
('1','Curmale umplute trase-n ciocolata', '20 curmale uscate (fara samburi), unt de arahide (natural 100%, neindulcit), 50 gr ciocolata neagra (60-80%), 1/2 lingura ulei cu gust neutru, sare Maldon',
'Cate un pic din toate. Putin dulce, putin sarat, putina proteina, putina cafeina, niste carbohidrati. Merg bine post workout.',
'E important sa aveti curmale deshidratate de calitate, care sa nu fie foarte uscate, sa se simta gumate si usor moi. Daca le cumparati fara samburi, au o taietura pe lateral. Prin acea taietura introduceti untul de arahide, cat intra in fiecare (cca /12 lingurita).
* daca untul de arahide e rece, de la frigider, procesul de umplere e mai usor
Intr-un vas mic topiti pe abur 35 gr din ciocolata pentru glazura. Luati vasul de pe abur. Adaugati restul de ciocolata si amestecati pana se topeste complet. Adaugati uleiul si omogenizati.
Inmuiati fiecare curmala umpluta in ciocolata topita, sa fie acoperita peste tot. Scoateti curmala din ciocolata cu o furculita pa care o bateti usor de marginea vasului astfel incat excesul de glazura de pe curmala sa se scurga printre dintii furculitei.
Asezati fiecare curmala glazurata pe un platou tapetat cu hartie de copt. Dati platoul la frigider 10-15 minute, sa inceapa sa se intareasca glazura, apoi presarati putina sare pe fiecare. Lasati sa se intareasca complet (la frigider merge mai repede), apoi le puteti muta intr-o cutie/bol. Se pastreaza la frigider de pe o zi pe alta.'),
('2','Muschiulet de porc la gratar cu guacamole, pico de gallo si fasole aromata',
'Muschiulet la gratar

1 muschiulet de porc mic (cca 350-400gr)
3 lingurite condiment cu boia afumata
2 linguri ulei de masline
piper negru

Guacamole

1 avocado copt
2 linguri suc de lime
sare

Pico de gallo

1 rosie medie (coapta)
1 ardei iute rosu
1 ceapa rosie mica
1/4 legatura patrunjel
2 linguri suc de lime
sare

Fasole aromata

1 conserva mica de fasole alba (250 gr dupa scurgere)
1/2 lingurta chimion macinat
1/4 lingurita coriandru macinat
1/4 lingurita fulgi de chili
1/8 lingurita cardamom macinat
1/8 lingurita turmeric pudra
2 fire patrunjel
5 frunze busuioc
coaja rasa de la 1/4 lamaie
2 linguri ulei de masline
sare, piper negru',
NULL,
'Muschiuletul se maseaza cu uleiul si condimentul cu boia afumata. Se rasneste apoi peste tot piper negru. Se lasa la frigider macar 3-4 ore si se scoate cu 15 minute inainte de pregatire.
Se incinge bine gratarul (cu carbuni sau gaz), daca aveti termostat pe capac sa arate 200C. Se aseaza muschiuletul pe gratarul incins si se coace cate 4-5 minute / parte cu capacul lasat jos. In acest timp trebuie sa se rumeneasca foarte bine, dar sa fie inca usor moale daca il apasati cu o furculita, semn ca e inca putin nefacut (roz) in interior.
Il scoateti pe un platou si il lasati sa stea 5 minute.
Pentru salsa se toaca ceapa rosie cubulete cat mai marunte. La fel si ardeiul iute. Se presara ceapa cu sare si se maseaza un pic sa se desfaca. Se lasa sa stea 5 minute. Se adauga apoi ardeiul iute si sucul de lime si se mai lasa sa stea 10 minute sa se macereze. La final se adauga patrunjelul tocat si rosia cubulete. Se amesteca usor.
Pentru fasole, se scurge conserva si se clateste bine fasolea cu apa. Se incinge o tigaie larga (cca 30 cm) si se adauga 1 lingura de ulei.
Se adauga chimionul, coriandrul, chili, cardamomul si turmericul si se amesteca sa se dizolve in grasime.
Se adauga fasolea bine scursa si se frige, amestecand cand si cand, cateva minute, pana apa de pe ea se evapora si e fierbinte. In acel moment, incepeti sa striviti fasolea cu o furculita si sa presarati sare, verdeturile tocate si coaja rasa de lamaie. Adaugati inca 1 lingura de ulei. Amestecati si sfaramati pana obtineti o pasta dar in care se mai vad bucatele de fasole. Va rezulta un piure rustic de fasole.
Guacamole il pregatiti doar inainte de servire. Scoateti miezul avocadoului intr-un bol. Presarati sare, adaugati sucul de lime si striviti cu furculita pana obtineti un piure rustic, in care se mai vad bucatele de avocado. Gustati si dregeti de sare si suc de lime.
Reveniti la muschiulet: il feliati cat mai subtire. Feliile vor mai avea o zona roz in centru. Reasezati feliile pe gratarul incins (de data asta cu capacul ridicat) si lasati-le doar 30 secunde / parte. Dupa ce le-ati insirat pe toate, practic le puteti intoarce. Nu trebuie lasate prea mult ca sa nu devina uscata carnea, doar cat sa nu se mai vada rozul in mijloc. Cateva felii dinspre capatul subtire e posibil sa nici nu aiba zona roz in centru, atunci nu le mai puneti pe gratar.
Asezati feliile de muschiulet pe un platou larg. Asezati alaturi pico de gallo, presarand putina si pe carne. Asezati langa salsa si piureul de fasolea. Guacamole il asezati in movilite unde mai este loc si decorati cu felii de lime. Presarati putina sare mare pe feliile de muschiulet. Serviti imediat.');


insert into ChefRecipe
values
('4','2'),
('5','1');

insert into Review
Values
('1', 'Best sweet snack', 5,'5','1');


insert into AspNetRoles
values ('Chef','Chef','CHEF',null),
('Admin','Admin','ADMIN',null);


----------------------------------------------------------------------------------------------
select * from Chef;
select * from Addresses;
select * from Recipes;
select * from Review;
select * from AspNetRoles;
select * from AspNetUsers;

delete from Chef;
delete from Addresses;
delete from Recipes;
