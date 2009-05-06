<?xml version="1.0" encoding="ISO-8859-1" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/weather">
    <table width="225px" border="0" cellSpacing="0" cellPadding="0" bgcolor="ffffff" ID="Table1">
      <tr>
        <td colspan="2" align="center" valign="center" 
            style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: Verdana">
          <xsl:value-of select="loc/dnam"></xsl:value-of>
        </td>
      </tr>
      <tr>
        <xsl:variable name="med-img-dir">./images/weather/</xsl:variable>
        <xsl:variable name="img-ext">gif</xsl:variable>
        <xsl:variable name="iconnumber">
          <xsl:value-of select="cc/icon"></xsl:value-of>
        </xsl:variable>
        <td height="64px" width="64px" align="center" valign="center">
          <img src="{$med-img-dir}/{$iconnumber}.{$img-ext}"></img>
        </td>
        <td width="161px" align="center" valign="center" style="FONT-SIZE: 22pt;
                    FONT-WEIGHT: bold">
          <xsl:value-of select="cc/tmp"></xsl:value-of>�F
        </td>
      </tr>
      <tr>
        <td align="center" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                    FONT-FAMILY: Verdana; HEIGHT: 33px">
          <xsl:value-of select="cc/t"></xsl:value-of>
        </td>
        <td align="center" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                    FONT-FAMILY: Verdana; HEIGHT: 33px">
          Feels like
          <xsl:value-of select="cc/flik"></xsl:value-of>�F
        </td>
      </tr>
      <table width="225px" border="0" cellSpacing="0" cellPadding="0" bgcolor="ffffff" ID="Table2">
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            UV Index:
          </td>
          <td width="40%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/uv/i"></xsl:value-of>
            <xsl:value-of select="cc/uv/t"></xsl:value-of>
          </td>
        </tr>
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            Dew Point:
          </td>
          <td width="40%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                     FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/dewp"></xsl:value-of>�F
          </td>
        </tr>
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            Humidity:
          </td>
          <td width="40%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/hmid"></xsl:value-of>%
          </td>
        </tr>
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            Visibility:
          </td>
          <td width="40%" align="left" valign="center" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/vis"></xsl:value-of>miles
          </td>
        </tr>
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="top" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            Pressure:
          </td>
          <td width="40%" align="left" valign="top" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/bar/r"></xsl:value-of>inches and
            <xsl:value-of select="cc/bar/d"></xsl:value-of>
          </td>
        </tr>
        <tr>
          <td width="10%"></td>
          <td width="50%" align="left" valign="top" style="FONT-SIZE: 9pt; COLOR: black; 
                     FONT-FAMILY: Verdana">
            Wind:
          </td>
          <td width="40%" align="left" valign="top" style="FONT-SIZE: 9pt; COLOR: black; 
                      FONT-FAMILY: Verdana">
            <xsl:value-of select="cc/wind/s"></xsl:value-of>mph
          </td>
        </tr>
      </table>
      <table width="225px" border="0" cellSpacing="0" cellPadding="0" bgcolor="ffffff" ID="Table3">
        <tr>
          <td colspan="5" width="100%" align="center"><u>Extended Forecast</u></td>
        </tr>
        <tr>
          <xsl:for-each select="dayf/day">
            <xsl:if test="@d > 0">
              <td width="25%" align="center" valign="top" style="FONT-SIZE: 7pt; COLOR: black; 
                          FONT-FAMILY: Verdana">
                <xsl:value-of select="@t"></xsl:value-of>
              </td>
            </xsl:if>
          </xsl:for-each>
        </tr>
        <tr>
          <xsl:variable name="small-img-dir">./images/weather/</xsl:variable>
          <xsl:variable name="img-ext">gif</xsl:variable>
          <xsl:for-each select="dayf/day">
            <xsl:if test="@d > 0">
              <xsl:variable name="iconnumber">
                <xsl:value-of select="part/icon"></xsl:value-of>
              </xsl:variable>
              <td width="25%" align="center" valign="center">
                <img border="1" src="{$small-img-dir}/{$iconnumber}.{$img-ext}"></img>
              </td>
            </xsl:if>
          </xsl:for-each>
        </tr>
        <tr>
          <xsl:for-each select="dayf/day">
            <xsl:if test="@d > 0">
              <td width="25%" align="center" valign="top" style="FONT-SIZE: 7pt; COLOR: black; 
                          FONT-FAMILY: Verdana">
                High:
                <xsl:value-of select="hi"></xsl:value-of>
              </td>
            </xsl:if>
          </xsl:for-each>
        </tr>
        <tr>
          <xsl:for-each select="dayf/day">
            <xsl:if test="@d > 0">
              <td width="25%" align="center" valign="top" style="FONT-SIZE: 7pt; COLOR: black; 
                          FONT-FAMILY: Verdana">
                Low:
                <xsl:value-of select="low"></xsl:value-of>
              </td>
            </xsl:if>
          </xsl:for-each>
        </tr>
        <tr>
          <xsl:for-each select="dayf/day">
            <xsl:if test="@d > 0">
              <td width="25%" align="center" valign="top" style="FONT-SIZE: 7pt; COLOR: black; 
                          FONT-FAMILY: Verdana">
                <xsl:value-of select="part/t"></xsl:value-of>
              </td>
            </xsl:if>
          </xsl:for-each>
        </tr>
      </table>
    </table>
  </xsl:template>
</xsl:stylesheet>