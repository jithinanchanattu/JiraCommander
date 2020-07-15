CREATE OR REPLACE PROCEDURE proc_name (
p_parameter1 IN INTEGER,
p_parameter2 IN INTEGER,
p_parameter3 IN INTEGER,
p_parameter4 OUT INTEGER,
p_parameter5 OUT VARCHAR2
)
IS
BEGIN
dbms_output.put_line ('Hurrah! Your first mapped file for procedure '|| proc_name||' was created successfully.');
p_parameter4 := (p_parameter1+p_parameter2);
p_parameter4 := p_parameter4 / p_parameter3;

BEGIN
SELECT TO_NUMBER('-AusDollars100','L9G999D99',
' NLS_NUMERIC_CHARACTERS = '',.''
 NLS_CURRENCY            = ''AusDollars'' 
') "Amount" INTO p_parameter5
 FROM DUAL;
EXCEPTION 
WHEN OTHERS THEN
NULL;
END;

dbms_output.put_line ('Integer Output Value is: '|| p_parameter4);
dbms_output.put_line ('Processed Parameter Character Value is: '|| p_parameter5);
END;
/