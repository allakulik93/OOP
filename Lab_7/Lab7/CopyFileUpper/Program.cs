USING SYSTEM;
USING SYSTEM.IO;
PUBLIC CLASS COPYFILEUPPER
{
    PUBLIC STATIC VOID MAIN()
    {
        STRING SFROM;
        STRING STO;
        STREAMREADER SRFROM;
        STREAMWRITER SWTO;
        CONSOLE.WRITELINE("ENTER A FILE INPUT NAME: ");
        SFROM = CONSOLE.READLINE();
        CONSOLE.WRITELINE("ENTER A FILE OUTPUT NAME: ");
        STO = CONSOLE.READLINE();

        TRY
        {

            SRFROM = NEW STREAMREADER(SFROM);
            SWTO = NEW STREAMWRITER(STO);

            WHILE (SRFROM.PEEK() != -1)
            {
                STRING SBUFFER = SRFROM.READLINE();
                SBUFFER = SBUFFER.TOUPPER();
                SWTO.WRITELINE(SBUFFER);

            }
            SWTO.CLOSE();
            SRFROM.CLOSE();
        }

        CATCH (FILENOTFOUNDEXCEPTION E)
        {
            CONSOLE.WRITELINE("FILE DOES NOT EXIST");
        }
        CATCH (EXCEPTION E)
        {
            CONSOLE.WRITELINE("ERROR");
            CONSOLE.WRITELINE(E.TOSTRING());
        }
    }
}

