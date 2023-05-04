import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CmethodsComponent } from './cmethods.component';

describe('CmethodsComponent', () => {
  let component: CmethodsComponent;
  let fixture: ComponentFixture<CmethodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CmethodsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CmethodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
