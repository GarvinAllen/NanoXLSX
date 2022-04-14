﻿using NanoXLSX;
using NanoXLSX.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NanoXLSX_Test.Styles.WriteRead
{
    public class FontWriteReadTest
    {

        [Theory(DisplayName = "Test of the writing and reading of the bold font style value")]
        [InlineData(true, "test")]
        [InlineData(false, 0.5f)]
        public void BoldFontTest(bool styleValue, object value)
        {
            Style style = new Style();
            style.CurrentFont.Bold = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.Bold);
        }

        [Theory(DisplayName = "Test of the writing and reading of the italic font style value")]
        [InlineData(true, "test")]
        [InlineData(false, 0.5f)]
        public void ItalicFontTest(bool styleValue, object value)
        {
            Style style = new Style();
            style.CurrentFont.Italic = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.Italic);
        }

        [Theory(DisplayName = "Test of the writing and reading of the strike font style value")]
        [InlineData(true, "test")]
        [InlineData(false, 0.5f)]
        public void StrikeFontTest(bool styleValue, object value)
        {
            Style style = new Style();
            style.CurrentFont.Strike = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.Strike);
        }

        [Theory(DisplayName = "Test of the writing and reading of the underline font style value")]
        [InlineData(Font.UnderlineValue.u_single, "test")]
        [InlineData(Font.UnderlineValue.u_double, 0.5f)]
        [InlineData(Font.UnderlineValue.doubleAccounting, true)]
        [InlineData(Font.UnderlineValue.singleAccounting, 42)]
        [InlineData(Font.UnderlineValue.none, "")]
        public void UnderlineFontTest(Font.UnderlineValue styleValue, object value)
        {
            Style style = new Style();
            style.CurrentFont.Underline = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.Underline);
        }

        [Theory(DisplayName = "Test of the writing and reading of the vertical alignment font style value")]
        [InlineData(Font.VerticalAlignValue.subscript, "test")]
        [InlineData(Font.VerticalAlignValue.superscript, 0.5f)]
        [InlineData(Font.VerticalAlignValue.none, true)]
        public void VerticalAlignFontTest(Font.VerticalAlignValue styleValue, object value)
        {
            Style style = new Style();
            style.CurrentFont.VerticalAlign = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.VerticalAlign);
        }

        [Theory(DisplayName = "Test of the writing and reading of the size font style value")]
        [InlineData(10.5f, "test")]
        [InlineData(11f, 0.5f)]
        [InlineData(50.55f, true)]
        public void SizeFontTest(float styleValue, float value)
        {
            Style style = new Style();
            style.CurrentFont.Size = styleValue;
            Cell cell = TestUtils.SaveAndReadStyledCell(value, style, "A1");
            Assert.Equal(styleValue, cell.CellStyle.CurrentFont.Size);
        }

    }
}
