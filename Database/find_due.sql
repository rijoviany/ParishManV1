call sp_get_family_due(1,2018);

select familyid,year,opening_balance;

SELECT     f.`familyid`,
	year(now()) as 'current_year',
    ifnull(ff.`opening_balance`,0) as opening_balance_due,
	IFNULL((ff.`january`+
    ff.`february`+
    ff.`march`+
    ff.`april`+
    ff.`may`+
    ff.`june`+
    ff.`july`+
    ff.`august`+
    ff.`september`+
    ff.`november`+
    ff.`december`+
    ff.`mission_sunday`+
    ff.`christmas_auction`+
    ff.`feast_vari`+
    ff.`donation_forane`+
    ff.`donation_diocese`+
    ff.`donation_seminary`+
    ff.`others`),0) as total_paid,
    IFNULL((ff.`january`+
    ff.`february`+
    ff.`march`+
    ff.`april`+
    ff.`may`+
    ff.`june`+
    ff.`july`+
    ff.`august`+
    ff.`september`+
    ff.`november`+
    ff.`december`+
    ff.`feast_vari`),0) as vari_paid,
    
    #due = current month x monthly vari + parish feast vari 
    ifnull((year(now())-p.start_year)*12 + month(now())*coalesce(f.monthly_vari,p.monthly_vari)+p.feast_vari,0) as 'to_pay',
	IFNULL((ff.`january`+ ff.`february`+ ff.`march`+ ff.`april`+ ff.`may`+ ff.`june`+ ff.`july`+ ff.`august`+ ff.`september`+ ff.`november`+ ff.`december`+ ff.`feast_vari`),0) -ifnull((year(now())-p.start_year)*12 + month(now())*coalesce(f.monthly_vari,p.monthly_vari)+p.feast_vari,0) as 'due_vari'
FROM `parishdb`.family f

left join parishdb.bcc_unit b on b.bcc_unitid=f.bcc_unitid
left join parishdb.parish p on p.parishid=b.parishid
left join parishdb.family_finance_txn ff on f.familyid=ff.familyid and ff.year>p.start_year
where f.familyid=1
group by f.familyid;


select f.familyid, p.start_year,ff.year from family f
left join family_finance_txn ff on f.familyid=ff.familyid
left join bcc_unit b on b.bcc_unitid=f.bcc_unitid
left join parish p on p.parishid=b.parishid
where f.familyid=6
group by f.familyid;


select  (p.monthly_vari*(year(now())-p.start_year)*12 + month(now())+p.feast_vari) from parish;

select (year(now())-2019)*12 + month(now())