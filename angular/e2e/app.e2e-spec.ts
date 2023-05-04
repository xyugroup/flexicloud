import { FlexiCloudPayTemplatePage } from './app.po';

describe('FlexiCloudPay App', function() {
  let page: FlexiCloudPayTemplatePage;

  beforeEach(() => {
    page = new FlexiCloudPayTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
