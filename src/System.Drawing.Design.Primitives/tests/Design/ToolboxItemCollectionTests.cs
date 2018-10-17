// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Drawing.Design
{
    public class ToolboxItemCollectionTests
    {
        private ToolboxItemCollection CreateToolboxItemCollection()
        {
            ToolboxItem[]  tools = { new ToolboxItem(), new ToolboxItem() };

            return new ToolboxItemCollection(tools);
        }

        [ConditionalFact(Helpers.GdiplusIsAvailable)]
        public void Contains_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateToolboxItemCollection();
            ToolboxItem value = unitUnderTest[0];

            // Act
            var result = unitUnderTest.Contains(
                value);

            // Assert
            Assert.True(result);
        }

        [ConditionalFact(Helpers.GdiplusIsAvailable)]
        public void IndexOf_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateToolboxItemCollection();
            ToolboxItem value = unitUnderTest[0];

            // Act
            var result = unitUnderTest.IndexOf(
                value);

            // Assert
            Assert.Equal(result, 0);
        }
    }
}
