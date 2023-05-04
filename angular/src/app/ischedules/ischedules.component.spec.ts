import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IschedulesComponent } from './ischedules.component';

describe('IschedulesComponent', () => {
  let component: IschedulesComponent;
  let fixture: ComponentFixture<IschedulesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IschedulesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IschedulesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
