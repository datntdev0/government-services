import { ServicesTemplatePage } from './app.po';

describe('Services App', function() {
  let page: ServicesTemplatePage;

  beforeEach(() => {
    page = new ServicesTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

