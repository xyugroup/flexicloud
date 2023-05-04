import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApaysComponent } from './apays.component';

describe('ApaysComponent', () => {
  let component: ApaysComponent;
  let fixture: ComponentFixture<ApaysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApaysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApaysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
