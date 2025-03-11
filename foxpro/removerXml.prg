SET SAFETY OFF
SET EXCLUSIVE OFF
CLEAR

* Caminho do banco DBF e da pasta XML
lcDBFPath = FULLPATH("MOVCAB.DBF")
lcXMLPath = FULLPATH("XML")

* Verifica se os arquivos existem
IF !FILE(lcDBFPath)
    ? "Erro: MOVCAB.DBF não encontrado."
    RETURN
ENDIF
IF !DIRECTORY(lcXMLPath)
    ? "Erro: Pasta XML não encontrada."
    RETURN
ENDIF

* Abre o banco e carrega as chaves já processadas
USE (lcDBFPath) SHARED
SELECT CH_NFE FROM MOVCAB INTO ARRAY laChaves
CLOSE DATABASES

* Criar arquivo de saída
lcLogFile = FULLPATH("chaves_processadas.txt")
STRTOFILE("", lcLogFile, 0)

* Percorrer os arquivos XML e verificar as chaves
lcArquivos = ADIR(laArquivos, lcXMLPath + "\*.xml")
FOR i = 1 TO ALEN(laArquivos,1)
    lcArquivo = lcXMLPath + "\" + laArquivos[i,1]
    lcConteudo = FILETOSTR(lcArquivo)
    
    * Extrai a chave da NFe do XML
    lnPos1 = AT("<chNFe>", lcConteudo)
    lnPos2 = AT("</chNFe>", lcConteudo)
    IF lnPos1 > 0 AND lnPos2 > lnPos1
        lcChave = SUBSTR(lcConteudo, lnPos1 + 7, lnPos2 - lnPos1 - 7)
        
        * Se a chave está no DBF, adiciona ao log
        IF ASCAN(laChaves, lcChave) > 0
            STRTOFILE(lcChave + CHR(13) + CHR(10), lcLogFile, 1)
        ENDIF
    ENDIF
ENDFOR

? "Processo concluído."
RETURN
